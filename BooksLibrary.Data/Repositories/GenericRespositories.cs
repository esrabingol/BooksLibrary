using BooksLibrary.Data.Abstract;
using BooksLibrary.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary.Data.Repositories
{
    public class GenericRespositories<T> : IRepositoryDal<T> where T : class
    {
        private readonly Connection _connection;
        public void Delete(int id)
        {
            var value = _connection.Set<T>().Find(id);
            _connection.Set<T>().Remove(value);
            _connection.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _connection.Set<T>().ToList();

        }

        public void Insert(T entity)
        {
            _connection.Set<T>().Add(entity);
            _connection.SaveChanges();
        }

        public void Update(T entity)
        {
            _connection.Set<T>().Update(entity);
            _connection.SaveChanges();
        }
    }
}
