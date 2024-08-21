using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace BackupMaker.UIKit.Converters
{
    internal class DoubleMultiplierConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double multiplier = 1.0;
            if (parameter is double factorD)
            {
                multiplier = factorD;
            }
            else if (parameter is string factorString)
            {
                if (double.TryParse(factorString, NumberStyles.Any, CultureInfo.InvariantCulture, out double parsedFactor))
                {
                    multiplier = parsedFactor;
                }
            }
            if (value is double doubleValue)
            {
                return doubleValue * multiplier;
            }
            else
            {
                return value;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
