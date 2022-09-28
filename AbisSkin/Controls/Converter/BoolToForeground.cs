using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;
using AbisSkin.Controls.Utils;

namespace AbisSkin.Controls.Converter
{
    public class BoolToForeground : IValueConverter
    {
        public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            if ((bool)value)
                return "#b22222".ToBrush();
            else
                return "#fdfdfd".ToBrush();
        }

        public object ConvertBack(object value, System.Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
