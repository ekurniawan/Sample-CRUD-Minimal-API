using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreBookStoreWebAPI.Models;

namespace CoreBookStoreWebAPI.Data
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