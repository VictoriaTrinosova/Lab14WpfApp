using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Lab14WpfApp
{
    class PictureConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if ((string)value == "1")
            {
                return "Data/ябл.png";
            }
            if ((string)value == "2")
            {
                return "Data/комп.png";
            }
            if ((string)value == "3")
            {
                return "Data/карт.png";
            }
            return "Data/принт.png";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
