using System;
using System.Collections.Generic;
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

namespace real_estate_UWP.Templates
{
    public sealed partial class ScreenTemplate : Page
    {
        public bool preventPaneClose = false;

        public ScreenTemplate()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            SplitViewe4ka.IsPaneOpen = !SplitViewe4ka.IsPaneOpen;
            if (!SplitViewe4ka.IsPaneOpen) preventPaneClose = false; else preventPaneClose = true;
        }

        private void TopItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TopItems.SelectedIndex == -1) return;
            switch ((TopItems.SelectedItem as ListBoxItem).Name)
            {
                case "RealEstateItem":
                    ContentPage.Navigate(typeof(Sections.RealEstate.RealEstateMain));
                    break;
                case "ContractsItem":
                    ContentPage.Navigate(typeof(Sections.Contracts.ContractsMain));
                    break;
                case "AdsItem":
                    ContentPage.Navigate(typeof(Sections.Ads.AdsMain));
                    break;
                case "ClientsItem":
                    ContentPage.Navigate(typeof(Sections.Clients.ClientsMain));
                    break;
                case "ReportingItem":
                    ContentPage.Navigate(typeof(Sections.Reporting.ReportingMain));
                    break;
            }
            if (SplitViewe4ka.DisplayMode == SplitViewDisplayMode.Overlay) SplitViewe4ka.IsPaneOpen = false;
            if (TopItems.SelectedIndex != -1 && BottomItems.SelectedIndex != -1) BottomItems.SelectedIndex = -1;
        }

        private void BottomItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (BottomItems.SelectedIndex == -1) return;
            switch ((BottomItems.SelectedItem as ListBoxItem).Name)
            {
                case "DraftsItem":
                    ContentPage.Navigate(typeof(Misc.Drafts.DraftsMain));
                    break;
                case "EmployeesItem":
                    ContentPage.Navigate(typeof(Misc.Employees.EmployeesMain));
                    break;
                case "SettingsItem":
                    ContentPage.Navigate(typeof(Misc.Settings.SettingsMain));
                    break;
            }
            if (SplitViewe4ka.DisplayMode == SplitViewDisplayMode.Overlay) SplitViewe4ka.IsPaneOpen = false;
            if (TopItems.SelectedIndex != -1 && BottomItems.SelectedIndex != -1) TopItems.SelectedIndex = -1;
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (Window.Current.Bounds.Width < 601)
            {
                HamburgerButton.Visibility = Visibility.Visible;
                SplitViewe4ka.DisplayMode = SplitViewDisplayMode.Overlay;
            }
            else
            {
                HamburgerButton.Visibility = Visibility.Collapsed;
                SplitViewe4ka.DisplayMode = SplitViewDisplayMode.Inline;
                SplitViewe4ka.IsPaneOpen = true;
                preventPaneClose = false;
            }
        }

        private void SplitViewe4ka_PaneClosing(SplitView sender, SplitViewPaneClosingEventArgs args)
        {
            if (preventPaneClose == true) args.Cancel = true;
        }
    }
}