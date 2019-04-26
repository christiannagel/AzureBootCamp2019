using BooksSample.Models;
using BooksSample.Services;
using System.Collections.Generic;
using System.Windows;

namespace BooksSample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private IEnumerable<Book> _books;

        public MainWindow()
        {
            InitializeComponent();
            _books = new BooksFactory().GetBooks();
            this.DataContext = _books;
        }
    }
}
