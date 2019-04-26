using BooksSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSample.Services
{
    public class BooksFactory
    {
        public Book GetTheBook() => new Book { Title = "Beginning Visual C#", Publisher = "Wrox Press", Authors = new[] { "Karli Watson", "Christian Nagel" } };

        public BooksFactory()
        {
            _books = new List<Book>()
            {
                 new Book { Title = "Beginning Visual C#", Publisher = "Wrox Press", Authors = new[] { "Karli Watson", "Christian Nagel" } },
                 new Book { Title = "Professional C# 7", Publisher = "Wrox Press", Authors = new[] { "Christian Nagel" } },
                 new Book { Title = "Enterprise Services", Publisher = "AWL", Authors = new[] { "Christian Nagel" } },

            };
        }

        private IEnumerable<Book> _books;

        public IEnumerable<Book> GetBooks() => _books; 
    }
}
