using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01.Models;

// Eduardo Barbosa Rodrigues e Vinicius Pontes Oliva
// Matheus Leandro Terra Luciano (CB3024881)

namespace TP01.Interface
{
    public interface IBookRepository
    {
        ICollection<Book> getAll();
        void add(Book book);
    }
}
