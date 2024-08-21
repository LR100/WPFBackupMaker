using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

// Use Color as System.Windows.Media.Color







namespace BackupMaker.UIKit.Converters
{
    internal class ColorBrightnessConverter : IValueConverter
    {
        private System.Windows.Media.Color ModifyColorBrightness(System.Windows.Media.Color color, double brightness)
        {
            double factor = Math.Clamp(brightness, 0.0, 2.0); // Ensure factor is between 0 and 4
            // Adjust the color's brightness
            byte r = (byte)Math.Clamp((double)(color.R * factor), 0, 255);
            byte g = (byte)Math.Clamp((double)(color.G * factor), 0, 255);
            byte b = (byte)Math.Clamp((double)(color.B * factor), 0, 255);
            return System.Windows.Media.Color.FromRgb(r, g, b);
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double brightnessFactor = 1.0;
            if (parameter is double factorD)
            {
                brightnessFactor = factorD;
            }
            else if (parameter is string factorString)
            {
                if (double.TryParse(factorString, NumberStyles.Any, CultureInfo.InvariantCulture, out double parsedFactor))
                {
                    brightnessFactor = parsedFactor;
                }
            }
            if (value is System.Windows.Media.Color color)
            {
                return ModifyColorBrightness(color, brightnessFactor);
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
