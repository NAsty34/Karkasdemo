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
    /// Логика взаимодействия для kod_pr.xaml
    /// </summary>
    public partial class kod_pr : Window
    {
        public kod_pr()
        {
            InitializeComponent();
            kodik.Focus();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (kodik.Text == "0000")
            {
                new AlminYsl().Show();
                Close();
            }
            else
            {
                MessageBox.Show("Вы ввели неправильный код. Введите 0000");
            }
        }

        private void kodik_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return) 
            {
                Button_Click(null, null);
            }
        }
    }
}
