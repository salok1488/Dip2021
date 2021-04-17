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
    /// Логика взаимодействия для Uchastok.xaml
    /// </summary>
    public partial class Uchastok : Page
    {
        public Uchastok()
        {
            InitializeComponent();
            using (uargazEntities db = new uargazEntities())
            {
                UchastokTB.ItemsSource = db.Участок.ToList();
            }
        }

        private List<Участок> FindValuePr(string searchQuery)
        {
            List<Участок> участокs = new List<Участок>();
            using (uargazEntities db = new uargazEntities())
            {
                foreach (Участок участок in db.Участок.ToList())
                {
                    if ($" {участок.Наименование}".IndexOf(searchQuery) >= 0)
                    {
                        участокs.Add(участок);
                    }
                }
            }
            return участокs;
        }
       

        private void SearchSotrudnik_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Участок> участокs = FindValuePr(Search.Text);
            UchastokTB.ItemsSource = участокs;
        }
    }
}
