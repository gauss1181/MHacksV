using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Net.Http;

namespace WpfApplication2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Console.Out.WriteLine("hi");
        }

        //overriding virtual method
        protected override void OnInitialized(EventArgs e)
        {
            base.OnInitialized(e);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            using (var client = new HttpClient())
            {
                // want to talk to azure server
                var responseString = client.GetStringAsync(string.Format("http://oauthbridge.azurewebsites.net/home/GetTweets?query={0}&lat={1}&lng{2}", query.Text, lat.Text, lng.Text));

                Console.Out.WriteLine(responseString.Result);
                // textbox1.Text = responseString.Result;
            }

        }



    }
}
