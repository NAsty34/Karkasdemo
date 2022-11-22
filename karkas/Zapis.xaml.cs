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
using System.Windows.Shapes;


namespace karkas
{
    /// <summary>
    /// Логика взаимодействия для Zapis.xaml
    /// </summary>
    public partial class Zapis : Window
    {
        public Zapis()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            string message = "Запись добавлена";
            string caption = "Ready";
            MessageBoxResult result = MessageBox.Show(message, caption);
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
          
            Close();
        }
    }
}
