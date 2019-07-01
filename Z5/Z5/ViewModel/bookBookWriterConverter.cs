using Data;
using System;
using System.Globalization;
using System.Windows.Data;

namespace ViewModel
{
    public class bookBookWriterConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return "null";

            bookBookWriter bookPublisher = (bookBookWriter)value;
            return bookPublisher.writerID;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bookBookWriter bookPublisher = new bookBookWriter
            {
                writerID = value.ToString()
            };
            return bookPublisher;
        }
    }
}
