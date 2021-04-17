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

namespace uargaz
{
    /// <summary>
    /// Логика взаимодействия для addZayavka.xaml
    /// </summary>
    public partial class addZayavka : Page
    {

        private Сотрудник _zayavka = new Сотрудник();
       
        public addZayavka()
        {
            InitializeComponent();

            DataContext = _zayavka;

            ComboSotrudnik.ItemsSource = uargazEntities.GetContext().Сотрудник.ToList();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_zayavka.Фамилия))
                errors.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_zayavka.Имя))
                errors.AppendLine("Укажите имя");
            if (_zayavka.Фамилия == null)
                errors.AppendLine("Выберите логин");

            if (errors.Length > 1)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_zayavka.Код == 0)
                uargazEntities.GetContext().Сотрудник.Add(_zayavka);


            try
            {
                uargazEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
