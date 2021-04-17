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
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            TablesTB.ItemsSource = uargazEntities.GetContext().Аварийная_работа.ToList();

        }
        private List<Аварийная_работа> FindValuePr(string searchQuery)
        {
            List<Аварийная_работа> аварийная_Работаs = new List<Аварийная_работа>();
            using (uargazEntities db = new uargazEntities())
            {
                foreach (Аварийная_работа аварийная_Работа  in db.Аварийная_работа.ToList())
                {
                    if ($" {аварийная_Работа.Повреждение}{аварийная_Работа.Характер_повреждения}".IndexOf(searchQuery) >= 0)
                    {
                        аварийная_Работаs.Add(аварийная_Работа);
                    }
                }
            }
            return аварийная_Работаs;
        }
       
        private void SearchSotrudnik_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Аварийная_работа> аварийная_Работаs  = FindValuePr(Search.Text);
            TablesTB.ItemsSource = аварийная_Работаs;
        }
    }
}
