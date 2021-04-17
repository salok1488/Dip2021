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
using uargaz.Views.Pages;

namespace uargaz
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(string name  , string image)
        {
            InitializeComponent();
            using (uargazEntities db = new uargazEntities())
            {
                login.Text = name;
                ava.ImageSource = new BitmapImage(new Uri(image));
                
            }
            MainFrame.Navigate(new MainPage());
            Manager.MainFrame = MainFrame;
            //MainFrame.Navigate(new sp1());
            //Manager.MainFrame = MainFrame;
            //using (Context db = new Context())
            //{
            //    //TablesTB.ItemsSource = db.Сотрудник.ToList();

            //}
        }

        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            //MainFrame.Navigate(new Page1());
            this.WindowState = WindowState.Minimized;
        }

        private void CloseButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }


        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }


        private void m_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Sp.Visibility == Visibility.Hidden)
                Sp.Visibility = Visibility.Visible;
            else
                Sp.Visibility = Visibility.Hidden;
        }

 


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Authorization f = new Authorization();
            f.Show();
            this.Close();
           
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }


        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
          
        }

       

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainPage());
        }

        private void Search_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Avarirabota());
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Brigada());
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Zayavka());
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Material());
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Svyaz());
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Sklad());
        }

        private void Button_Click_12(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Smena());
        }

        private void Button_Click_13(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Sotrudnik());
        }

        private void Button_Click_14(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Transport());
        }

        private void Button_Click_15(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new Uchastok());
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainPage());
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new OtchetZayavlenie());
        }
    }
}
