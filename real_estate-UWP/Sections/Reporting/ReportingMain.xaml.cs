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

using Windows.UI.Popups;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace real_estate_UWP.Sections.Reporting
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ReportingMain : Page
    {
        public ReportingMain()
        {
            this.InitializeComponent();
        }

        private void Page_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            if (ContentContainer.ActualWidth < 601)
            {
                ContentArea.Width = ContentContainer.ActualWidth - ContentContainer.Padding.Right * 2;
            }
            else ContentArea.Width = 450;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            var messageDialog = new MessageDialog("Файл отправлен на корпоративную почту.");
            messageDialog.Title = "Отчет сгенерирован.";

            // Set the command that will be invoked by default
            messageDialog.DefaultCommandIndex = 0;

            // Set the command to be invoked when escape is pressed
            messageDialog.CancelCommandIndex = 1;

            // Show the message dialog
            await messageDialog.ShowAsync();
        }
    }
}
