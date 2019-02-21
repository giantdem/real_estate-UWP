using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace real_estate_UWP.Sections.Ads
{
    public sealed partial class AdsMain : Page
    {
        public AdsMain()
        {
            this.InitializeComponent();

            this.ViewModel = new AdsVM();
        }

        public AdsVM ViewModel { get; set; }

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
            this.Frame.Navigate(typeof(AdsView));
        }

        private void filter_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AdsFilter));
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AdsAdd));
        }
    }

    public class AdItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool? isActive { get; set; }

        public AdItem()
        {
            this.Title = "Имя записи";
            this.Description = "Краткая информация";
            this.isActive = true;
        }
    }

    public class AdsVM
    {
        public AdItem DefaultTestItem { get; } = new AdItem();
        public ObservableCollection<AdItem> Ads { get; } = new ObservableCollection<AdItem>();

        public AdsVM()
        {
            this.Ads.Add(new AdItem()
            {
                Title = "Объявление 1",
                Description = "11.12.2019",
                isActive = true
            });
            this.Ads.Add(new AdItem()
            {
                Title = "Объявление 2",
                Description = "12.12.2019",
                isActive = false
            });
        }
    }

}
