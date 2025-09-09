using CBTSWE2.Aula02.Repositorio;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using System.Net.Http.Headers;

namespace CBTSWE2.Aula02
{ 
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        public void Configure(IApplicationBuilder app)
        {
            var builder = new RouteBuilder(app);
            builder.MapRoute("Livros/ParaLer", LivrosParaLer);
            builder.MapRoute("Livros/Lendo", LivrosLendo);
            builder.MapRoute("Livros/Lido", LivrosLidos);
            builder.MapRoute("Cadastro/NovoLivro/{nome}/{autor}", NovoLivroParaLer);
            var rotas = builder.Build();

            app.UseRouter(rotas);
        }

        public Task LivrosParaLer(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            return context.Response.WriteAsync(_repo.ParaLer.ToString());
        }

        public Task LivrosLendo(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            return context.Response.WriteAsync(_repo.Lendo.ToString());
        }

        public Task LivrosLidos(HttpContext context)
        {
            var _repo = new LivroRepositorioCSV();
            return context.Response.WriteAsync(_repo.Lidos.ToString());
        }

        public Task NovoLivroParaLer(HttpContext context)
        {
            var livro = new Negocio.Livro()
            {
                Titulo = context.GetRouteValue("nome").ToString(),
                Autor = context.GetRouteValue("autor").ToString(),
            };
            var repo = new LivroRepositorioCSV();
            repo.Incluir(livro);
            return context.Response.WriteAsync("O livro foi adicionado com suesso");
        }
    }
}