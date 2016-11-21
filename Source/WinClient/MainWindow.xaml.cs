using System.Windows;
using Refit;
using WinClient.Pages;

namespace WinClient
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var api = RestService.For<IWebApiChat>("http://127.0.0.1:5000/api");

            var rs = await api.Register("1", "2");

            //var res = await api.GetMessages(0, 10);

            RootFrame.NavigationService.Navigate(new RegisterPage());
        }
    }
}