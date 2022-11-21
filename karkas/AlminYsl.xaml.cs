using karkas.AppDataFile;
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
    /// Логика взаимодействия для AlminYsl.xaml
    /// </summary>
    public partial class AlminYsl : Window
    {
        public AlminYsl()
        {
            InitializeComponent();
            Class1.conObj = new Mihailova_demoEntities2();
            var basis = Class1.conObj.Service.ToList();
            foreach (var item in basis)
            {
                if (item.Discount > 0)
                {
                    item.Discountskid = item.Discount + "% скидка";
                    item.oldcost = string.Format("{0:#.00руб.}", item.Cost);
                    item.Cost = (decimal)(((double)item.Cost) * ((100 - item.Discount) / 100));
                }
            }
            serviceList.ItemsSource = basis;
        }
            private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            new Edit().Show();
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string message = "Запись удалена";
            string caption = "Remove";
            MessageBoxResult result = MessageBox.Show(message, caption);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Add().Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Zapis().Show();
        }
    }
}
