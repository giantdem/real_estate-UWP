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

namespace real_estate_UWP.Templates
{
    public sealed partial class SectionTemplate : Page
    {
        public SectionTemplate()
        {
            this.InitializeComponent();

            this.ViewModel = new TestViewModel();
        }

        public TestViewModel ViewModel { get; set; }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (ContentContainer.ActualWidth < 601)
            {
                ContentArea.Width = ContentContainer.ActualWidth - ContentContainer.Padding.Right * 2;
            }
            else ContentArea.Width = 450;
        }
    }

    public class TestItem
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public TestItem()
        {
            this.Title = "Имя записи";
            this.Description = "Краткая информация";
        }
    }
    public class TestViewModel
    {
        public TestItem DefaultTestItem { get; } = new TestItem();
        public ObservableCollection<TestItem> TestItems { get; } = new ObservableCollection<TestItem>();

        public TestViewModel()
        {
            this.TestItems.Add(new TestItem()
            {
                Title = "Имя записи",
                Description = "Краткая информация"
            });
            this.TestItems.Add(new TestItem()
            {
                Title = "Имя записи",
                Description = "Краткая информация"
            });
            this.TestItems.Add(new TestItem()
            {
                Title = "Имя записи",
                Description = "Краткая информация"
            });
        }
    }
}
