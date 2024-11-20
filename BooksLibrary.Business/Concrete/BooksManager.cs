using BooksLibrary.Business.Abstract;
using BooksLibrary.Data.Abstract;
using BooksLibrary.Entities.Concrete;
using BooksLibrary.Shared.Utilities.Result.Abstract;
using BooksLibrary.Shared.Utilities.Result.ComplexTypes;
using BooksLibrary.Shared.Utilities.Result.Concrete;
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

        public async Task<IResult> TDelete(int id)
		{
			_booksDal.Delete(id);
            return new Result(ResultStatus.Success," Kitap başarıyla silinmiştir.");
        }

		public List<Books> TGetAll()
		{
			return _booksDal.GetAll();
		}

		public async Task<IResult> TInsert(Books entity)
		{
			_booksDal.Insert(entity);
            return new Result(ResultStatus.Success, $"{entity.Title} başlıklı Kitap başarıyla eklenmiştir.");
        }

		public async Task<IResult> TUpdate(Books entity)
		{
			_booksDal.Update(entity);
            return new Result(ResultStatus.Success, $"{entity.Title} başlıklı Kitap başarıyla güncellenmiştir.");
        }

	}
}
