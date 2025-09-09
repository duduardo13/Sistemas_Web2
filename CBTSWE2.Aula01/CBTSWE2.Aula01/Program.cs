using CBTSWE2.Aula01.Negocio;
using CBTSWE2.Aula01.Repositorio;

var _repo = new LivroRepositorioCSV();
ImprimeLista(_repo.ParaLer);
ImprimeLista(_repo.Lendo);
ImprimeLista(_repo.Lidos);

static void ImprimeLista(ListaDeLeitura lista)
{
    Console.WriteLine(lista);
}