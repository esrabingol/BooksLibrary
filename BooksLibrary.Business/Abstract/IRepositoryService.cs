using BooksLibrary.Shared.Utilities.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary.Business.Abstract
{
	public interface IRepositoryService<T> where T : class
	{
        Task<IResult> TInsert(T entity);
        Task<IResult> TUpdate(T entity);
        Task<IResult> TDelete(int id);
		List<T> TGetAll();
	}
}
