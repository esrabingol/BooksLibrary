using BooksLibrary.Business.Abstract;
using BooksLibrary.Data.Abstract;
using BooksLibrary.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary.Business.Concrete
{

	public class BooksManager : IBooksService
	{
		private readonly IBooksDal _booksDal;
		public BooksManager(IBooksDal categoryDal)
		{
			_booksDal = categoryDal;
		}
		public void TDelete(int id)
		{
			_booksDal.Delete(id);
		}

		public List<Books> TGetAll()
		{
			return _booksDal.GetAll();
		}

		public void TInsert(Books entity)
		{
			_booksDal.Insert(entity);
		}

		public void TUpdate(Books entity)
		{
			_booksDal.Update(entity);
		}
	}
}
