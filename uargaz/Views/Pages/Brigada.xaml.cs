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
    /// Логика взаимодействия для Brigada.xaml
    /// </summary>
    public partial class Brigada : Page
    {
        public Brigada()
        {
            InitializeComponent();
            using (uargazEntities db = new uargazEntities())
            {
                BrigadaTB.ItemsSource = db.Бригада.ToList();
            }
        }

        
    }
}
