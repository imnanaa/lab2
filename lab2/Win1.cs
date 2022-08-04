using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace lab2
{


    class Win1 : Window
    {

        private MainWindow mainWindow;
        private Button ToHome;
        private Button Confirm;
        private Button Delete;
        private TextBox TB1;
        private TextBox TB2;
        private TextBox TB3;
        private TextBox TB4;
        private TextBox TB5;
        private Label label;

        public Win1(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            initialize();
        }
        private void initialize()
        {
            this.Title = "Win1";
            this.ResizeMode = ResizeMode.NoResize;
            this.WindowStyle = WindowStyle.None;
            this.Height = 450;
            this.Width = 800;
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;


            //---------------фон вікна----------------------------
            ImageBrush myBrush = new ImageBrush();
            Image image = new Image();
            image.Source = new BitmapImage(new Uri("C:/Users/wiixv/OneDrive/Desktop/KPI/random staff/jupiter.jpg"));
            myBrush.ImageSource = image.Source;
            myBrush.Stretch = Stretch.UniformToFill;
            //______________________________________________________________

            Grid grid = new Grid();
            grid.Background = myBrush;
            
            //-----------buttons---------------------

            ToHome = new Button();// головне меню
            ToHome.Width = 85;
            ToHome.Height = 60;
            ToHome.Content = "Mеню";
            ToHome.VerticalAlignment = VerticalAlignment.Top;
            ToHome.HorizontalAlignment = HorizontalAlignment.Left;
            ToHome.Background = Brushes.Black;
            ToHome.BorderBrush = null;
            ToHome.Foreground = Brushes.Lavender;
            ToHome.FontSize = 20;
            ToHome.FontFamily = new FontFamily("Book Antiqua");
            ToHome.Margin = new Thickness(664, 354, 10, 10);
            ToHome.Click += onReturnBtnClick;
            grid.Children.Add(ToHome);

            Confirm = new Button();//підтвердити виконання дії
            Confirm.Width = 130;
            Confirm.Height = 50;
            Confirm.Content = "Підтвердити";
            Confirm.VerticalAlignment = VerticalAlignment.Top;
            Confirm.HorizontalAlignment = HorizontalAlignment.Left;
            Confirm.Background = Brushes.Black;
            Confirm.BorderBrush = null;
            Confirm.Foreground = Brushes.Lavender;
            Confirm.FontSize = 16;
            Confirm.FontFamily = new FontFamily("Book Antiqua");
            Confirm.Margin = new Thickness(335, 192, 335, 192);
            Confirm.Click += ConfirmBtnClick;
            grid.Children.Add(Confirm);


            Delete = new Button();//видалити студента
            Delete.Width = 130;
            Delete.Height = 50;
            Delete.Content = "Видалити";
            Delete.VerticalAlignment = VerticalAlignment.Top;
            Delete.HorizontalAlignment = HorizontalAlignment.Left;
            Delete.Background = Brushes.Black;
            Delete.BorderBrush = null;
            Delete.Foreground = Brushes.Lavender;
            Delete.FontSize = 16;
            Delete.FontFamily = new FontFamily("Book Antiqua");
            Delete.Margin = new Thickness(309, 344, 361, 40);
            Delete.Click += DeleteBtnClick;
            grid.Children.Add(Delete);

            //----------------text boxes-----------------------------
            TB1 = new TextBox();
            TB1.Width = 129;
            TB1.Height = 40;
            TB1.FontSize = 16;
            TB1.FontFamily = new FontFamily("Book Antiqua");
            TB1.VerticalAlignment = VerticalAlignment.Top;
            TB1.HorizontalAlignment = HorizontalAlignment.Left;
            TB1.Margin = new Thickness(155, 62, 515, 338);
            grid.Children.Add(TB1);


            TB2 = new TextBox();
            TB2.Width = 120;
            TB2.Height = 40;
            TB2.FontSize = 16;
            TB2.FontFamily = new FontFamily("Book Antiqua");
            TB2.VerticalAlignment = VerticalAlignment.Top;
            TB2.HorizontalAlignment = HorizontalAlignment.Left;
            TB2.Margin = new Thickness(189, 122, 481, 276);
            grid.Children.Add(TB2);

            TB3 = new TextBox();
            TB3.Width = 122;
            TB3.Height = 40;
            TB3.FontSize = 16;
            TB3.FontFamily = new FontFamily("Book Antiqua");
            TB3.VerticalAlignment = VerticalAlignment.Top;
            TB3.HorizontalAlignment = HorizontalAlignment.Left;
            TB3.Margin = new Thickness(629, 62, 41, 332);
            grid.Children.Add(TB3);

            TB4 = new TextBox();
            TB4.Width = 122;
            TB4.Height = 40;
            TB4.FontSize = 16;
            TB4.FontFamily = new FontFamily("Book Antiqua");
            TB4.VerticalAlignment = VerticalAlignment.Top;
            TB4.HorizontalAlignment = HorizontalAlignment.Left;
            TB4.Margin = new Thickness(617, 120, 53, 274);
            grid.Children.Add(TB4);

            TB5 = new TextBox();
            TB5.Width = 89;
            TB5.Height = 40;
            TB5.FontSize = 16;
            TB5.FontFamily = new FontFamily("Book Antiqua");
            TB5.VerticalAlignment = VerticalAlignment.Top;
            TB5.HorizontalAlignment = HorizontalAlignment.Left;
            TB5.Margin = new Thickness(179, 338, 531, 52);
            grid.Children.Add(TB5);

            //----------------labels----------------
            Label label;

            label = new Label();
            label.Content = "ПІП";
            label.VerticalAlignment = VerticalAlignment.Top;
            label.HorizontalAlignment = HorizontalAlignment.Left;
            label.Width = 47;
            label.Height = 30;
            label.FontSize = 16;
            label.Background = Brushes.Sienna;
            label.Foreground = Brushes.WhiteSmoke;
            label.Opacity = 0.8;
            label.FontFamily = new FontFamily("Book Antiqua");
            label.Margin = new Thickness(43, 62, 627, 332);
            grid.Children.Add(label);

            label = new Label();
            label.Content = "№ залік. книжки";
            label.VerticalAlignment = VerticalAlignment.Top;
            label.HorizontalAlignment = HorizontalAlignment.Left;
            label.Width = 189;
            label.Height = 30;
            label.FontSize = 16;
            label.Background = Brushes.LightGray;
            label.Opacity = 0.8;
            label.FontFamily = new FontFamily("Book Antiqua");
            label.Margin = new Thickness(37, 122, 627, 272);
            grid.Children.Add(label); 
            
            label = new Label();
            label.Content = "Курс";
            label.VerticalAlignment = VerticalAlignment.Top;
            label.HorizontalAlignment = HorizontalAlignment.Left;
            label.Width = 52;
            label.Height = 30;
            label.FontSize = 16;
            label.Background = Brushes.Peru;
            label.Opacity = 0.8;
            label.FontFamily = new FontFamily("Book Antiqua");
            label.Margin = new Thickness(473, 62, 197, 332);
            grid.Children.Add(label); 
            
            label = new Label();
            label.Content = "Спецільність";
            label.VerticalAlignment = VerticalAlignment.Top;
            label.HorizontalAlignment = HorizontalAlignment.Left;
            label.Width = 128;
            label.Height = 39;
            label.FontSize = 18;
            label.Background = Brushes.LightGray;
            label.Opacity = 0.8;
            label.FontFamily = new FontFamily("Book Antiqua");
            label.Margin = new Thickness(471, 122, 199, 272);
            grid.Children.Add(label); 
            
            label = new Label();
            label.Content = "№ залік. книжки";
            label.VerticalAlignment = VerticalAlignment.Top;
            label.HorizontalAlignment = HorizontalAlignment.Left;
            label.Width = 151;
            label.Height = 30;
            label.FontSize = 14;
            label.Background = Brushes.LightBlue;
            label.Opacity = 0.8;
            label.FontFamily = new FontFamily("Book Antiqua");
            label.Margin = new Thickness(45, 340, 625, 42);
            grid.Children.Add(label);
            
            label = new Label();
            label.Content = "Видалити студента";
            label.VerticalAlignment = VerticalAlignment.Top;
            label.HorizontalAlignment = HorizontalAlignment.Left;
            label.Width = 156;
            label.Height = 35;
            label.FontSize = 16;
            label.Background = Brushes.LightBlue;
            label.Opacity = 0.8;
            label.FontFamily = new FontFamily("Book Antiqua");
            label.Margin = new Thickness(63, 272, 581, 126);
            grid.Children.Add(label);


            this.Content = grid;
        }

        private void onReturnBtnClick(object sender, RoutedEventArgs args)
        {
            this.Hide();
            mainWindow.Show();
        }

        private void ConfirmBtnClick(object sender, RoutedEventArgs args)
        {
            StreamReader list = new StreamReader("result.txt");
            StreamWriter stu = new StreamWriter("list2.txt");
            string l = list.ReadLine();
            string text = TB1 + " " + TB2.Text + " " + TB3.Text + " " + TB4.Text;
            stu.WriteLine(l);
            stu.WriteLine(text.ToString());
            stu.Close();
            list.Close();
            StreamReader num = new StreamReader("list2.txt");
            StreamWriter mun = new StreamWriter("result.txt");
            while (!num.EndOfStream)
            {
                string text2 = num.ReadLine();
                mun.WriteLine(text2);
            }
            num.Close();
            mun.Close();
        }
        struct Student
        {
            string pip;
            int zal;
            int spec;
            int kurs;
            public Student(string pip, int zal, int spec, int kurs)
            {
                this.pip = pip;
                this.zal = zal;
                this.spec = spec;
                this.kurs = kurs;
            }
            public string getPip() => pip;
            public int getZal() => zal;
            public int getSpec() => spec;
            public int getKurs() => kurs;

        }


        private void DeleteBtnClick(object sender, RoutedEventArgs e)
        {
            StreamReader stu = new StreamReader("result.txt");
            StreamWriter del = new StreamWriter("list2.txt");
            int numToFind = Convert.ToInt32(TB5.Text);
            string[] line = new string[100];
            int k = 0;
            while (!stu.EndOfStream)
            {
                line[k] = stu.ReadLine();
                k++;
            }
            int m = 0;
            while (!stu.EndOfStream)
            {
                string[] lines = line[m].Trim().Split(' ');
                int n = 0;
                string pip = lines[n];
                int zal = Convert.ToInt32(lines[n + 1]);
                int spec = Convert.ToInt32(lines[n + 2]);
                int kurs = Convert.ToInt32(lines[n + 3]);
                if (m == k && zal != numToFind) del.WriteLine($"{pip} {zal} {spec} {kurs}");
                m++;
            }
            del.Close();
            stu.Close();
            StreamReader num = new StreamReader("list2.txt");
            StreamWriter mun = new StreamWriter("result.txt");
            string[] text2 = new string[100];
            k = 0;
            while (!num.EndOfStream)
            {
                text2[k] = num.ReadLine();
                mun.WriteLine(text2[k]);
                k++;
            }
            num.Close();
            mun.Close();
        }

        private void Spec_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


    }
}


