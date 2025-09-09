﻿using CBTSWE2.Aula03;
using CBTSWE2.Aula03.Negocio;
using CBTSWE2.Aula03.Repositorio;
using Microsoft.AspNetCore.Hosting;

var _repo = new LivroRepositorioCSV();
IWebHost host = new WebHostBuilder()
    .UseKestrel()
    .UseStartup<Startup>()
    .Build();
host.Run();

ImprimeLista(_repo.ParaLer);
ImprimeLista(_repo.Lendo);
ImprimeLista(_repo.Lidos);

static void ImprimeLista(ListaDeLeitura lista)
{
    Console.WriteLine(lista);
}