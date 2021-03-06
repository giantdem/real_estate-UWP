﻿using System;
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

namespace real_estate_UWP.Sections.RealEstate
{
    public sealed partial class RealEstateMain : Page
    {
        public RealEstateMain()
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

        private void add_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(REAdd));
        }

        private void inspections_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(REInspections));
        }
    }

    public class REItem
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public REItem()
        {
            this.Title = "Имя записи";
            this.Description = "Краткая информация";
        }
    }

    public class REVM
    {
        public REItem DefaultTestItem { get; } = new REItem();
        public ObservableCollection<REItem> RE { get; } = new ObservableCollection<REItem>();

        public REVM()
        {
            this.RE.Add(new REItem()
            {
                Title = "Объект 1",
                Description = "Квартира"
            });
            this.RE.Add(new REItem()
            {
                Title = "Объект 2",
                Description = "Офис"
            });
        }
    }

}
