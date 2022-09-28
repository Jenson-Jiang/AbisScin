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
    public class AbisTabItem : TabItem
    {
        public static readonly DependencyProperty RemarkProperty = ElementBase.Property<AbisTabItem, ImageSource>("RemarkProperty", null);

        public string Remark { get { return (string)GetValue(RemarkProperty); } set { SetValue(RemarkProperty, value); } }

        public AbisTabItem()
        {
            Utility.Refresh(this);
        }

        static AbisTabItem()
        {
            ElementBase.DefaultStyle<AbisTabItem>(DefaultStyleKeyProperty);
        }
        #region Path属性
        public static readonly DependencyProperty PathWidthProperty = DependencyProperty.Register("PathWidth"
            , typeof(double), typeof(AbisTabItem), new FrameworkPropertyMetadata(0d));
        /// <summary>
        /// Path的宽度
        /// </summary>
        public double PathWidth
        {
            get { return (double)GetValue(PathWidthProperty); }
            set { SetValue(PathWidthProperty, value); }
        }

        public static readonly DependencyProperty PathDataProperty = DependencyProperty.Register("PathData"
            , typeof(Geometry), typeof(AbisTabItem));
        /// <summary>
        /// Path的Data
        /// </summary>
        public Geometry PathData
        {
            get { return (Geometry)GetValue(PathDataProperty); }
            set { SetValue(PathDataProperty, value); }
        }

        public static readonly DependencyProperty IconTextMarginProperty =
            DependencyProperty.Register("IconTextMargin", typeof(double), typeof(AbisTabItem), new PropertyMetadata(0.0));
        /// <summary>
        /// 图标文字间隔
        /// </summary>
        public double IconTextMargin
        {
            get { return (double)GetValue(IconTextMarginProperty); }
            set { SetValue(IconTextMarginProperty, value); }
        }
        #endregion
    }
}
