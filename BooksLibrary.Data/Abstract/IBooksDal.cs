using BooksLibrary.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary.Data.Abstract
{
	public interface IBooksDal: IRepositoryDal<Books>
	{
	}
}
