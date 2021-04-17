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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Avarirabota : Page
    {
        public Avarirabota()
        {
            InitializeComponent();
            using (uargazEntities db = new uargazEntities())
            {
                avaria.ItemsSource = db.Аварийная_работа.ToList();
            }

        }

        private List<Аварийная_работа> FindValuePr(string searchQuery)
        {
            List<Аварийная_работа> _av = new List<Аварийная_работа>();
            using(uargazEntities db = new uargazEntities())
            {
                foreach (Аварийная_работа pq in db.Аварийная_работа.ToList())
                {
                    if ($" {pq.Повреждение} {pq.Характер_повреждения} {pq.Время_конца} {pq.Время_начала} {pq.Объект} ".IndexOf(searchQuery) >= 0)
                    {
                        _av.Add(pq);
                    }
                }
            }
            return _av;


        }

        private void SearchAvariya_TextChanged(object sender, TextChangedEventArgs e)
        {
            List<Аварийная_работа> аварийная_Работаs = FindValuePr(SearchAvariya.Text);
            avaria.ItemsSource = аварийная_Работаs;
        }

        private void avaria_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}