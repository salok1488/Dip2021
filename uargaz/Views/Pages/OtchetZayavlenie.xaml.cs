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
using Word = Microsoft.Office.Interop.Word;


namespace uargaz.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для OtchetZayavlenie.xaml
    /// </summary>
    public partial class OtchetZayavlenie : Page
    {
        public OtchetZayavlenie()
        {
            InitializeComponent();
        }

        private readonly string TemplateFileName = @"C:\выходные документы\Заявление на проведении аварийных работ.docx";

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var глава = tb1.Text;
                var объект =  tb2.Text;
                var адрес = tb3.Text;
                var дата1 = Convert.ToString(dp1.SelectedDate);
                дата1 = dp1.SelectedDate.Value.ToShortDateString();
                var дата2 = Convert.ToString(dp2.SelectedDate);
                дата2 = dp2.SelectedDate.Value.ToShortDateString();
                var ответственный = tb4.Text;
                var организация = tb5.Text;
                var документы = tb6.Text;
                var результат = tb7.Text;
                var заявитель = tb8.Text;
                var дата3 = Convert.ToString(dp3.SelectedDate);
                дата3 = dp3.SelectedDate.Value.ToShortDateString();
                var wordApp = new Word.Application();
                wordApp.Visible = true;

                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{name1}", глава, wordDocument);
                ReplaceWordStub("{name2}", объект, wordDocument);
                ReplaceWordStub("{name3}", адрес, wordDocument);
                ReplaceWordStub("{name4}", дата1, wordDocument);
                ReplaceWordStub("{name5}", дата2, wordDocument);
                ReplaceWordStub("{name6}", ответственный, wordDocument);
                ReplaceWordStub("{name7}", организация, wordDocument);
                ReplaceWordStub("{name8}", документы, wordDocument);
                ReplaceWordStub("{name9}", результат, wordDocument);
                ReplaceWordStub("{name10}", заявитель, wordDocument);
                ReplaceWordStub("{name11}", дата3, wordDocument);
                // wordDocument.SaveAs2(@"C:\выходные документы\Заявление на проведении аварийных работ.docx");
                //wordDocument.Close();
                wordApp.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("укажите все данные");
            }
        }

        private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
        {
            var range = wordDocument.Content;
            range.Find.ClearFormatting();
            range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
        }
    }
}
