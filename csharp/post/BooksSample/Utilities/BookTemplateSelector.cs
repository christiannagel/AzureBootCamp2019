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
            => item switch
            {
                Book { Publisher: "Wrox Press" } => WroxTemplate,
                Book _ => DefaultBookTemplate,
                _ => null
            };         
    }
}
