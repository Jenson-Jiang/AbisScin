using AbisSkin.Utility.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace AbisSkin.Controls.Core
{
    public class ButtonSkin : Button
    {
        /// <summary>
        /// Svg data
        /// </summary>
        public static readonly DependencyProperty IconProperty = ElementBase.Property<AbisWindow, Geometry>("IconProperty");

        /// <summary>
        /// Image Source
        /// </summary>
        public static readonly DependencyProperty ImageProperty = ElementBase.Property<AbisWindow, ImageSource>("ImageProperty");

        /// <summary>
        /// 角的弧度
        /// </summary>
        public static readonly DependencyProperty CornerRadiusProperty = ElementBase.Property<ButtonSkin, CornerRadius>("CornerRadiusProperty");

        /// <summary>
        /// Svg Data
        /// </summary>
        public Geometry Icon { get { return (Geometry)GetValue(IconProperty); } set { SetValue(IconProperty, value); } }

        /// <summary>
        /// Image Source
        /// </summary>
        public ImageSource Image { get { return (ImageSource)GetValue(ImageProperty); } set { SetValue(ImageProperty, value); } }

        /// <summary>
        /// 角的弧度
        /// </summary>
        public CornerRadius CornerRadius { get { return (CornerRadius)GetValue(CornerRadiusProperty); } set { SetValue(CornerRadiusProperty, value); } }
    }
}
