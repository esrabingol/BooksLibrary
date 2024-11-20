using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksLibrary.Entities.Concrete
{
	public class Books
	{
		
		public int BooksId { get; set; }
		public string Title {get; set; }
		public string Author {get ; set; }
		public DateTime PublishedYear {get; set; }
		public string Genre { get; set; }
	}
}
