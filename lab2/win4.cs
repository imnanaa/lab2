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

namespace lab2
{
    class Win4 : Window
    {
        private MainWindow mainWindow;
        private Button ToHome;

        public Win4(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            initialize();
        }

        private void initialize()
        {
            this.Title = "Win4";
            this.ResizeMode = ResizeMode.NoResize;
            this.WindowStyle = WindowStyle.None;
            this.Height = 387.5;
            this.Width = 723.864;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;

            //---------------фон вікна----------------------------
            ImageBrush myBrush = new ImageBrush();
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("C:/Users/wiixv/OneDrive/Desktop/KPI/random staff/nasa2.jpg"));
            myBrush.ImageSource = image.Source;
            myBrush.Stretch = Stretch.UniformToFill;
            //______________________________________________________________

            Grid grid = new Grid();
            grid.Background = myBrush;

            ToHome = new Button(); 
            ToHome.Width = 85;
            ToHome.Height = 60;
            ToHome.Content = "Mеню";
            ToHome.VerticalAlignment = VerticalAlignment.Top;
            ToHome.HorizontalAlignment = HorizontalAlignment.Left;
            ToHome.Background = Brushes.Black;
            ToHome.BorderBrush = null;
            ToHome.Foreground = Brushes.WhiteSmoke;
            ToHome.FontSize = 20;
            ToHome.FontFamily = new FontFamily("Book Antiqua");
            ToHome.Margin = new Thickness(37, 194, 0, 0);
            ToHome.Click += onReturnBtnClick;

            //--------labels------------------------
            Label label;

            label = new Label();
            label.Content = "   Яворська Анна Сергіївна";
            label.VerticalAlignment = VerticalAlignment.Top;
            label.HorizontalAlignment = HorizontalAlignment.Left;
            label.Foreground= Brushes.WhiteSmoke;
            label.Background = Brushes.Black;
            label.Opacity = 0.8;
            label.Width = 575;
            label.Height = 64;
            label.FontSize = 36;
            label.FontFamily = new FontFamily("Bookman Old Style");
            label.Margin = new Thickness(83, 81, 0, 0);
            grid.Children.Add(label);

            label = new Label();
            label.Content = "2021-2022 ";
            label.VerticalAlignment = VerticalAlignment.Top;
            label.HorizontalAlignment = HorizontalAlignment.Left;
            label.Width = 250;
            label.Height = 64;
            label.FontSize = 30;
            label.Foreground = Brushes.Tan;
            label.Opacity = 0.6;
            label.FontFamily = new FontFamily("Bookman Old Style");
            label.Margin = new Thickness(507, 276, 0, -58);
            grid.Children.Add(label);

            label = new Label();
            label.Content = "Група КП-13 ";
            label.VerticalAlignment = VerticalAlignment.Top;
            label.HorizontalAlignment = HorizontalAlignment.Left;
            label.Width = 300;
            label.Height = 60;
            label.FontSize = 36;
            label.Foreground = Brushes.WhiteSmoke;
            label.Background = Brushes.Black;
            label.Opacity = 0.8;
            label.FontFamily = new FontFamily("Bookman Old Style");
            label.Margin = new Thickness(246, 150, 0, 0);
            grid.Children.Add(label);

            //---------------------------------

            grid.Children.Add(ToHome);

            this.Content = grid;
        }

        private void onReturnBtnClick(object sender, RoutedEventArgs args)
        {
            this.Hide();
            mainWindow.Show();
        }

    }
}
