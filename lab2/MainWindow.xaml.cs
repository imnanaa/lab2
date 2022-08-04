using System.Windows;

namespace lab2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Win1 Win1;
        private Win2 Win2;
        private Win3 Win3;
        private Win4 Win4;

        public MainWindow()
        {
            InitializeComponent();
            Win1 = new Win1(this);
            Win2 = new Win2(this);
            Win3 = new Win3(this);
            Win4 = new Win4(this);

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Win4.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Hide();
            Win2.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Hide();
            Win3.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Hide();
            Win1.Show();
        }
    }
}
