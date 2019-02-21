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

namespace real_estate_UWP.Sections.Clients
{
    public sealed partial class ClientsMain : Page
    {
        public ClientsMain()
        {
            this.InitializeComponent();

            this.ViewModel = new ClientsVM();
        }

        public ClientsVM ViewModel { get; set; }

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
            this.Frame.Navigate(typeof(ClientsView));
        }

        private void filter_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ClientsFilter));
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ClientsAdd));
        }
    }

    public class ClientItem
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public ClientItem()
        {
            this.Title = "Имя записи";
            this.Description = "Краткая информация";
        }
    }

    public class ClientsVM
    {
        public ClientItem DefaultTestItem { get; } = new ClientItem();
        public ObservableCollection<ClientItem> Clients { get; } = new ObservableCollection<ClientItem>();

        public ClientsVM()
        {
            this.Clients.Add(new ClientItem()
            {
                Title = "Клиент Клиентов",
                Description = "Физическое лицо"
            });
            this.Clients.Add(new ClientItem()
            {
                Title = "ООО «Зеленоглазое такси»",
                Description = "Юридическое лицо"
            });
        }
    }

}
