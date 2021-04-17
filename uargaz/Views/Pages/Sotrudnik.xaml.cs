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
    /// Логика взаимодействия для Sotrudnik.xaml
    /// </summary>
    public partial class Sotrudnik : Page
    {
      
        public Sotrudnik()
        {
            InitializeComponent();
            //using (saloEntities db = new saloEntities())
            //{
            //    SotrudnikTB.ItemsSource = db.Сотрудник.ToList();
            //}
            SotrudnikTB.ItemsSource = uargazEntities.GetContext().Сотрудник.ToList();
        }

       
        private List<Сотрудник> FindValuePr(string searchQuery)
        {
            List<Сотрудник> сотрудникs = new List<Сотрудник>();
            using (uargazEntities db = new uargazEntities())
            {
                foreach (Сотрудник Сотрудник in db.Сотрудник.ToList())
                {
                    if ($" {Сотрудник.Фамилия}{Сотрудник.Имя}".IndexOf(searchQuery) >= 0)
                    {
                        сотрудникs.Add(Сотрудник);
                    }
                }
            }
            return сотрудникs;
        }
        private void PhoneTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Сотрудник> сотрудникs = FindValuePr( SearchSotrudnik.Text);
            SotrudnikTB.ItemsSource = сотрудникs;
        }

        private void add_Click(object sender, RoutedEventArgs e)
        {

            //add f = new add(null);
            //f.Show();
            Manager.MainFrame.Navigate(new addsotr());
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var hotelsForRemoving = SotrudnikTB.SelectedItems.Cast<Сотрудник>().ToList();

            if (MessageBox.Show($"вы точно хотите удалить слудующие {hotelsForRemoving.Count()} элементы?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    uargazEntities.GetContext().Сотрудник.RemoveRange(hotelsForRemoving);
                    uargazEntities.GetContext().SaveChanges();
                    MessageBox.Show("данные удалены");

                    SotrudnikTB.ItemsSource = uargazEntities.GetContext().Сотрудник.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }

        private void ContextMenuAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new addsotr());
        }

        private void ContextMenuRemove_Click(object sender, RoutedEventArgs e)
        {
            var hotelsForRemoving = SotrudnikTB.SelectedItems.Cast<Сотрудник>().ToList();

            if (MessageBox.Show($"вы точно хотите удалить слудующие {hotelsForRemoving.Count()} элементы?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    uargazEntities.GetContext().Сотрудник.RemoveRange(hotelsForRemoving);
                    uargazEntities.GetContext().SaveChanges();
                    MessageBox.Show("данные удалены");

                    SotrudnikTB.ItemsSource = uargazEntities.GetContext().Сотрудник.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
