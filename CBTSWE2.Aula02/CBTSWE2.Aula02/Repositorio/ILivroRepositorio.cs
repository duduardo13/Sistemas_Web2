using CBTSWE2.Aula02.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CBTSWE2.Aula02.Repositorio
{
    public interface ILivroRepositorio
    {
        ListaDeLeitura ParaLer { get; }
        ListaDeLeitura Lendo { get; }
        ListaDeLeitura Lidos { get; }
        IEnumerable<Livro> Todos { get; }
        void Incluir(Livro livro);
    }
}
