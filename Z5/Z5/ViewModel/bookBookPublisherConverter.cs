using Data;
using System;
using System.Globalization;
using System.Windows.Data;

namespace ViewModel
{
    public class bookBookPublisherConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return "null";

            bookBookPublisher bookPublisher = (bookBookPublisher)value;
            return bookPublisher.publisherID;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bookBookPublisher bookPublisher = new bookBookPublisher
            {
                publisherID = value.ToString()
            };
            return bookPublisher;
        }
    }
}
