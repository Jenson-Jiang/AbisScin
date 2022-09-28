using AbisSkin.Utility.Element;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace AbisSkin.Controls.Core
{
    public class AbisImage : ContentControl
    {
        public static readonly DependencyProperty SourceProperty = ElementBase.Property<AbisImage, ImageSource>("SourceProperty");
        public static readonly DependencyProperty StretchProperty = ElementBase.Property<AbisImage, Stretch>("StretchProperty");
        public static readonly DependencyProperty StretchDirectionProperty = ElementBase.Property<AbisImage, StretchDirection>("StretchDirectionProperty");
        public static readonly DependencyProperty ImageWidthProperty = ElementBase.Property<AbisImage, double>("ImageWidthProperty");
        public static readonly DependencyProperty ImageHeightProperty = ElementBase.Property<AbisImage, double>("ImageHeightProperty");
        public static readonly DependencyProperty ImageVerticalAlignmentProperty = ElementBase.Property<AbisImage, VerticalAlignment>("ImageVerticalAlignmentProperty");
        public static readonly DependencyProperty ImageHorizontalAlignmentProperty = ElementBase.Property<AbisImage, HorizontalAlignment>("ImageHorizontalAlignmentProperty");

        public ImageSource Source { get { return (ImageSource)GetValue(SourceProperty); } set { SetValue(SourceProperty, value); } }
        public Stretch Stretch { get { return (Stretch)GetValue(StretchProperty); } set { SetValue(StretchProperty, value); } }
        public StretchDirection StretchDirection { get { return (StretchDirection)GetValue(StretchDirectionProperty); } set { SetValue(StretchDirectionProperty, value); } }
        public double ImageWidth { get { return (double)GetValue(ImageWidthProperty); } set { SetValue(ImageWidthProperty, value); } }
        public double ImageHeight { get { return (double)GetValue(ImageHeightProperty); } set { SetValue(ImageHeightProperty, value); } }
        public VerticalAlignment ImageVerticalAlignment { get { return (VerticalAlignment)GetValue(ImageVerticalAlignmentProperty); } set { SetValue(ImageVerticalAlignmentProperty, value); } }
        public HorizontalAlignment ImageHorizontalAlignment { get { return (HorizontalAlignment)GetValue(ImageHorizontalAlignmentProperty); } set { SetValue(ImageHorizontalAlignmentProperty, value); } }

        static AbisImage()
        {
            ElementBase.DefaultStyle<AbisImage>(DefaultStyleKeyProperty);
        }

        public AbisImage()
        {

        }

        public AbisImage(ImageSource image)
        {
            Source = image;
        }


    }
}
