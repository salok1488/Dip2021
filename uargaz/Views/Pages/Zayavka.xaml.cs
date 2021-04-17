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
    /// Логика взаимодействия для Zayavka.xaml
    /// </summary>
    public partial class Zayavka : Page
    {
        public Zayavka()
        {
            InitializeComponent();
            using (uargazEntities db = new uargazEntities())
            {
                ZayavkaTB.ItemsSource = db.Заявка.ToList();
            }
        }

        private void ContextMenuAdd_Click(object sender, RoutedEventArgs e)
        {
            Manager.MainFrame.Navigate(new addZayavka());
        }

        private void ContextMenuRemove_Click(object sender, RoutedEventArgs e)
        {
            var zaForRemoving = ZayavkaTB.SelectedItems.Cast<Заявка>().ToList();

            if (MessageBox.Show($"вы точно хотите удалить слудующие {zaForRemoving.Count()} элементы?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    uargazEntities.GetContext().Заявка.RemoveRange(zaForRemoving);
                    uargazEntities.GetContext().SaveChanges();
                    MessageBox.Show("данные удалены");

                    ZayavkaTB.ItemsSource = uargazEntities.GetContext().Заявка.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
        }
    }
}
