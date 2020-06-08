using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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

namespace Thread_Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static readonly DependencyProperty HtmlProperty = DependencyProperty.RegisterAttached(
            "Html",
            typeof(string),
            typeof(MainWindow),
            new FrameworkPropertyMetadata(OnHtmlChanged));
            
   
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            Task.Run(() =>
            {
                Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId}");
                HttpClient httpClient = new HttpClient();
                string html = httpClient.GetStringAsync("http://ipv4.download.thinkbroadband.com/5MB.zip").Result;
                MyButton.Dispatcher.Invoke(() =>
                {
                    Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId} owns MyButton");

                    MyButton.Content = "Done";
                });
                
            });
            //MessageBox.Show("Hi");
            

        }

        private async void MyButton_Click2(object sender, RoutedEventArgs e)
        {
            string myHtml = "Bla";fdg fc h      b          
            await Task.Run(async() =>
            {
                Debug.WriteLine($"Thread Nr. {Thread.CurrentThread.ManagedThreadId}");
                HttpClient httpClient = new HttpClient(); 
                string html = httpClient.GetStringAsync("https://google.com").Result;
                myHtml = html;
            });
            MyButton2.Content = "Downloaded";
            MyWebBrower.SetValue(HtmlProperty, myHtml);
        }

        static void OnHtmlChanged(DependencyObject dependencyObject, DependencyPropertyChangedEventArgs e)
        {
            WebBrowser web = dependencyObject as WebBrowser;
            if(web != null)
            {
                web.NavigateToString(e.NewValue as String);
            }
        }
    }
}
