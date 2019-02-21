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

namespace real_estate_UWP.Misc.Employees
{
    public sealed partial class EmployeesMain : Page
    {
        public EmployeesMain()
        {
            this.InitializeComponent();

            this.ViewModel = new EmployeesVM();
        }

        public EmployeesVM ViewModel { get; set; }

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
            this.Frame.Navigate(typeof(EmployeesView));
        }

        private void filter_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EmployeesFilter));
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(EmployeesAdd));
        }
    }

    public class EmployeeItem
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public EmployeeItem()
        {
            this.Title = "Имя записи";
            this.Description = "Краткая информация";
        }
    }

    public class EmployeesVM
    {
        public EmployeeItem DefaultTestItem { get; } = new EmployeeItem();
        public ObservableCollection<EmployeeItem> Employees { get; } = new ObservableCollection<EmployeeItem>();

        public EmployeesVM()
        {
            this.Employees.Add(new EmployeeItem()
            {
                Title = "Петров Пётр Петрович",
                Description = "Главный шут"
            });
            this.Employees.Add(new EmployeeItem()
            {
                Title = "Сараев Поджог",
                Description = "Босс без отчества"
            });
        }
    }

}