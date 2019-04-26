using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooksSample.Models
{
    public class Book : BindableBase
    {
        public int BookId { get; set; }
        private string _title;

        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        private string _publisher;

        public string Publisher
        {
            get => _publisher;
            set => SetProperty(ref _publisher, value);
        }

        private string[] authors;

        public string[] Authors
        {
            get { return authors; }
            set { authors = value; }
        }

        public override string ToString() => Title;
    }
}
