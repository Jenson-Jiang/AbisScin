using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace AbisSkin.Themes
{
    public class Theme
    {
        public static void Switch(Visual myVisual)
        {
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(myVisual); i++)
            {
                Visual childVisual = (Visual)VisualTreeHelper.GetChild(myVisual, i);
                if (childVisual != null)
                {
                    Controls.Utility.Refresh(childVisual as FrameworkElement);
                    Switch(childVisual);
                }
            }
        }
    }
}
