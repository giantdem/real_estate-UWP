using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

namespace real_estate_UWP.Sections.Contracts
{
    public sealed partial class ContractsMain : Page
    {
        public ContractsMain()
        {
            this.InitializeComponent();

            this.ViewModel = new ContractsVM();
        }

        public ContractsVM ViewModel { get; set; }

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
            this.Frame.Navigate(typeof(ContractsView));
        }

        private void filter_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ContractsFilter));
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ContractsAdd));
        }

        private void requests_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ContractsRequests));
        }
    }

    public class ContractItem
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public ContractItem()
        {
            this.Title = "Имя записи";
            this.Description = "Краткая информация";
        }
    }

    public class ContractsVM
    {
        public ContractItem DefaultTestItem { get; } = new ContractItem();
        public ObservableCollection<ContractItem> Contracts { get; } = new ObservableCollection<ContractItem>();

        public ContractsVM()
        {
            this.Contracts.Add(new ContractItem()
            {
                Title = "Контракт 00001",
                Description = "Аренда"
            });
            this.Contracts.Add(new ContractItem()
            {
                Title = "Контракт 00002",
                Description = "Продажа"
            });
        }
    }

}
