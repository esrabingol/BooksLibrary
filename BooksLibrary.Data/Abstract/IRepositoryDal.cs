using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary.Data.Abstract
{
	public interface IRepositoryDal<T> where T : class
	{
		void Insert(T entity);
		void Update(T entity);
		void Delete(int id);
		List<T> GetAll();
	}
}
