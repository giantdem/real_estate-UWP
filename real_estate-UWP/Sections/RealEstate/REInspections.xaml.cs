using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace real_estate_UWP.Sections.RealEstate
{
    public sealed partial class REInspections : Page
    {
        public REInspections()
        {
            this.InitializeComponent();

            this.ViewModel = new REVM();
        }

        public REVM ViewModel { get; set; }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (ContentContainer.ActualWidth < 601)
            {
                ContentArea.Width = ContentContainer.ActualWidth - ContentContainer.Padding.Right * 2;
            }
            else ContentArea.Width = 450;
        }

        private void listViewe4ka_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Frame.Navigate(typeof(REView));
        }

        private void filter_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(REFilter));
        }
    }
}
