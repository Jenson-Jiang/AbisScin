using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace AbisSkin.Controls.Converter
{
   public class BoolToVisibility: IValueConverter
   {
      public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture)
      {
         if ((bool)value)
            return Visibility.Visible;
         else
            return Visibility.Collapsed;
      }

      public object ConvertBack(object value, System.Type targetType, object parameter, CultureInfo culture)
      {
         throw new NotImplementedException();
      }
   }

   public class BoolToReVisibility : IValueConverter
   {
      public object Convert(object value, System.Type targetType, object parameter, CultureInfo culture)
      {
         if ((bool)value)
            return Visibility.Collapsed;
         else
            return Visibility.Visible;
      }

      public object ConvertBack(object value, System.Type targetType, object parameter, CultureInfo culture)
      {
         throw new NotImplementedException();
      }
   }

   
}
