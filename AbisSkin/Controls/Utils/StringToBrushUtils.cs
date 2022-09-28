using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace AbisSkin.Controls.Utils
{
    public static class StringToBrushUtils
    {
        public static BrushConverter BrushConverter = new BrushConverter();

        public static Brush ToBrush(this string color)
        {
            try
            {
                return (Brush)BrushConverter.ConvertFromString(color);
            }
            catch 
            {
                return Brushes.White;
            }
        }
    }
}
