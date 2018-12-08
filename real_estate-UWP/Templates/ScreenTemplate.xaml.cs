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
        public ScreenTemplate()
        {
            this.InitializeComponent();
        }

        private void HamburgerButton_Click(object sender, RoutedEventArgs e)
        {
            SplitViewe4ka.IsPaneOpen = !SplitViewe4ka.IsPaneOpen;
        }

        private void TopItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TopItems.SelectedIndex == 0) TopItems.SelectedItem.ToString();
            if (TopItems.SelectedIndex == 1) Debug.WriteLine("А это второй элемент");
            if (TopItems.SelectedIndex != -1 && BottomItems.SelectedIndex != -1) BottomItems.SelectedIndex = -1;
        }

        private void BottomItems_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (TopItems.SelectedIndex != -1 && BottomItems.SelectedIndex != -1) TopItems.SelectedIndex = -1;
        }
    }
}
