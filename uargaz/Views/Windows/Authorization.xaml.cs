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
using System.Windows.Shapes;

namespace uargaz
{
    /// <summary>
    /// Логика взаимодействия для Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        string name;
        string image;
             
        public Authorization()
        {
            InitializeComponent();
        }

        private void CloseButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void MinButton_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }


        private void Logo_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                this.DragMove();
            }
        }


        private void on_PasswordChanged(object sender, RoutedEventArgs e)
        {
            //if (on.Password.Length > 0)
            //{
            //    Watermark.Visibility = Visibility.Collapsed;
            //}
            //else
            //{
            //    Watermark.Visibility = Visibility.Visible;
            //}
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string password = PasswordBox.PasswordCharProperty.ToString();
            using (uargazEntities db = new uargazEntities())
            {
                foreach (Учётная_запись logins in db.Учётная_запись)
                {
                    string b = login.Text;
                    string c =on.Password.ToString();
                    if (logins.login == b && logins.password == c)
                    {
                       
                        foreach (Сотрудник сотрудник in db.Сотрудник)
                        {
                            if (logins.Код == сотрудник.Код_учётной_записи)
                            {
                                name = сотрудник.Фамилия+" "+сотрудник.Имя + " " + сотрудник.Отчество;
                                image = сотрудник.Фото;
                            }
                        }
                    }
                }
                if (db.Учётная_запись.Any(o => o.login == login.Text && o.password == on.Password))
                {
                    MainWindow f = new MainWindow(name, image );
                    f.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }
    }
}
