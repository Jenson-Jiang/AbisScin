using AbisScin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;

namespace AbisScin.Views
{
    /// <summary>
    /// ContentAssembly.xaml 的交互逻辑
    /// </summary>
    public partial class ImageAssembly : UserControl
    {
        public ImageAssembly()
        {
            InitializeComponent();
        }

        private void MediaElement_Loaded(object sender, RoutedEventArgs e)
        {
            //element.Source = new Uri("/Resources/Images/TEST.png", UriKind.Relative);
            //element.LoadedBehavior = MediaState.Manual;
            //element.Stretch = Stretch.Fill;
            //element.Play();
        }

        /// <summary>
        /// 结束后事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void element_MediaEnded(object sender, RoutedEventArgs e)
        {
            //element.Position = TimeSpan.FromMilliseconds(1);
            //element.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ViewModelLocator.Assembly.IsLove = !ViewModelLocator.Assembly.IsLove;
        }
    }
}
