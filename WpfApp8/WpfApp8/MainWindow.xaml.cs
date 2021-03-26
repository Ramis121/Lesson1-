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
using System.Xml;
using System.IO;

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_click1(object sender, RoutedEventArgs e)
        {
            Item it = new Item();
            textbox1.Text = ($"{it.Title = " habr"}\n {it.Description = "Новости 34"}\n {it.PubDate = DateTime.Now.ToString()}");
        }

        private void Xml_Fail()
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\Users\wolfr\OneDrive\Рабочий стол\Stap It\XML\habr.xml")) 
                {
                    string line = sr.ReadToEnd();
                    textbox1.Text = line;
                }
            }
            catch(Exception e)
            {
                throw new Exception(textbox1.Text = e.Message);
            }
        }

        private void button_Click2(object sender, RoutedEventArgs e)
        {
            Xml_Fail();
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {
        }

        private void textbox2_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
