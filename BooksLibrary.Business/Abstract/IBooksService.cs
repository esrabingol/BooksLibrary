﻿using BooksLibrary.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary.Business.Abstract
{
	public interface IBooksService :IRepositoryService<Books>
	{

    }
}
