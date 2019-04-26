using System;
using System.Globalization;
using System.Windows.Data;

namespace BooksSample.Converters
{
    [ValueConversion(typeof(string[]), typeof(string))]
    public class StringArrayToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string[] names = (string[])value ?? throw new ArgumentNullException(nameof(value));
            return string.Join(GetSeparator(parameter), names);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string names = value?.ToString() ?? throw new ArgumentNullException(nameof(value));
            return names.Split(new [] { GetSeparator(parameter) }, StringSplitOptions.None);
        }

        private string GetSeparator(object parameter) => parameter?.ToString() ?? ", "; 
    }
}
