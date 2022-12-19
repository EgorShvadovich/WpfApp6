using System.Windows;

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string x = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            x += "1";
            label1.Content = x;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            x += "2";
            label1.Content = x;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            x += "3";
            label1.Content = x;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            x += "4";
            label1.Content = x;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            x += "5";
            label1.Content = x;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            x += "6";
            label1.Content = x;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            x += "7";
            label1.Content = x;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            x += "8";
            label1.Content = x;
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            x += "9";
            label1.Content = x;
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            x += "0";
            label1.Content = x;
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            x = "";
            label1.Content = x;
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            if (x == "1111")
            {
                MessageBox.Show("YOU YGADAL");
                x = "";
                label1.Content = x;
            }
            else
            {
                MessageBox.Show("YOU NE YGADAL,TRY AGAIN","WEARNING!");
                x = "";
                label1.Content = x;
            }
        }
    }
}
