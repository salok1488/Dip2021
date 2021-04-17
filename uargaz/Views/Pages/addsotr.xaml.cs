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
    /// Логика взаимодействия для addsotr.xaml
    /// </summary>
    public partial class addsotr : Page
    {
        private Сотрудник _sotr = new Сотрудник();
        public addsotr()
        {
            InitializeComponent();

            DataContext = _sotr;
           
            ComboLogin.ItemsSource = uargazEntities.GetContext().Учётная_запись.ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_sotr.Фамилия))
                errors.AppendLine("Укажите фамилию");
            if (string.IsNullOrWhiteSpace(_sotr.Имя))
                errors.AppendLine("Укажите имя");
            if (string.IsNullOrWhiteSpace(_sotr.Отчество))
                errors.AppendLine("Укажите отчество");
           
           
            if (_sotr.Учётная_запись == null)
                errors.AppendLine("Выберите логин");

            if (errors.Length > 1)
            {
                MessageBox.Show(errors.ToString());
                return;
            }

            if (_sotr.Код == 0)
                uargazEntities.GetContext().Сотрудник.Add(_sotr);
            
            try
            {
                uargazEntities.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            Manager.MainFrame.Navigate(new Sotrudnik());
        }
    }
}
