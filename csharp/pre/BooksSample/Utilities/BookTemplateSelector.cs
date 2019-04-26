using BooksSample.Models;
using System.Windows;
using System.Windows.Controls;

namespace BooksSample.Utilities
{
    public class BookTemplateSelector : DataTemplateSelector
    {
        public DataTemplate WroxTemplate { get; set; }
        public DataTemplate DefaultBookTemplate { get; set; }
        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            DataTemplate selectedTemplate = null;
            if (item is Book book)
            {
                switch (book.Publisher)
                {
                    case "Wrox Press":
                        selectedTemplate = WroxTemplate;
                        break;
                    default:
                        selectedTemplate = DefaultBookTemplate;
                        break;
                }
            }

            return selectedTemplate;
        }
    }
}
