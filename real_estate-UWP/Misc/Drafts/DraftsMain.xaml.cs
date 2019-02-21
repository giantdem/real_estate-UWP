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

namespace real_estate_UWP.Misc.Drafts
{
    public sealed partial class DraftsMain : Page
    {
        public DraftsMain()
        {
            this.InitializeComponent();

            this.ViewModel = new DraftsVM();
        }

        public DraftsVM ViewModel { get; set; }

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
            this.Frame.Navigate(typeof(DraftsView));
        }

        private void filter_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(DraftsFilter));
        }
    }

    public class DraftItem
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public DraftItem()
        {
            this.Title = "Имя записи";
            this.Description = "Краткая информация";
        }
    }

    public class DraftsVM
    {
        public DraftItem DefaultTestItem { get; } = new DraftItem();
        public ObservableCollection<DraftItem> Drafts { get; } = new ObservableCollection<DraftItem>();

        public DraftsVM()
        {
            this.Drafts.Add(new DraftItem()
            {
                Title = "Контракт 00001",
                Description = "Аренда"
            });
            this.Drafts.Add(new DraftItem()
            {
                Title = "Объект 1",
                Description = "Квартира"
            });
        }
    }

}
