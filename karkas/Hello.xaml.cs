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
    /// Логика взаимодействия для Hello.xaml
    /// </summary>
    public partial class Hello : Window
    {
        public Hello()
        {
            InitializeComponent();
            DateTime date = DateTime.Now;
            if (date.Hour>=4 && date.Hour < 11)
            {
                privet.Text = "Доброе утро ♥";
            }
            else if ( date.Hour >= 11 && date.Hour < 17)
            {
                privet.Text = "Добрый день ♥";
            }
            else 
            {
                privet.Text = "Добрый вечер ♥";
            }
        }
    }
}
