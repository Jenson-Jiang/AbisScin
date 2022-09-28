using AbisSkin.Utility.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace AbisSkin.Controls.Core
{
    public class AbisStackPagePanel : FrameworkElement
    {
        public static readonly DependencyProperty CountProperty = ElementBase.Property<AbisWindow, int>("CountProperty");
        public int Count { get { return (int)GetValue(CountProperty); } set { SetValue(CountProperty, value); } }

        public static readonly DependencyProperty PageCountProperty = ElementBase.Property<AbisWindow, int>("PageCountProperty");
        public int PageCount { get { return (int)GetValue(PageCountProperty); } set { SetValue(PageCountProperty, value); } }

    }
}
