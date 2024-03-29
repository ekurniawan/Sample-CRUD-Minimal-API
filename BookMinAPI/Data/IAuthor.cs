using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMinAPI.Models;

namespace BookMinAPI.Data
{

    public interface IAuthor
    {
        Task<IEnumerable<Author>> GetAll();
        Task<Author> Insert(Author author);
        Task<Author> GetById(int id);
        Task<Author> Update(Author author);
        Task Delete(int id);
    }

}