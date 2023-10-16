using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ITISystem.ViewModel.Converter
{
    public class DateToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime dateValue)
            {
                // Convert the DateTime to a string with a specific format
                return dateValue.ToString("yyyy-MM-dd"); // You can customize the format as needed
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string stringValue)
            {
                // Try parsing the string to a DateTime
                if (DateTime.TryParseExact(stringValue, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dateValue))
                {
                    return dateValue;
                }
            }

            return DateTime.MinValue; // You can return another default value if parsing fails
        }
    }
}
