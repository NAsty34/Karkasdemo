using karkas.AppDataFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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
            tim();
            
          
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Service sr = ((Button)sender).DataContext as Service;
            var w = new Edit();
            w.init(sr);

            w.ShowDialog();
            var basis = Class1.conObj.Service.ToList();
            foreach (var item in basis)
            {
                if (item.Discount > 0)
                {
                    item.Discountskid = item.Discount + "% скидка";
                    item.oldcost = string.Format("{0:#.00руб.}", item.Cost);
                    item.Cost_stat = (decimal)(((double)item.Cost) * ((100 - item.Discount) / 100));
                    item.Foreground = "#00FF7F";
                }
                else
                {
                    item.Foreground = null;
                    item.Discountskid = null;
                    item.oldcost = null;
                    item.Cost_stat = item.Cost;
                }
                item.DurationInMin = item.DurationInSeconds / 60;
            }
            serviceList.ItemsSource = basis;
            serviceList.Items.Refresh();


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var R_S = ((Button)sender).DataContext as Service;

            Class1.conObj.ClientService.RemoveRange(R_S.ClientService);
            Class1.conObj.ServicePhoto.RemoveRange(R_S.ServicePhoto);
            Class1.conObj.Service.Remove(R_S);
            Class1.conObj.SaveChanges();
            (serviceList.ItemsSource as List<Service>).Remove(R_S);

            serviceList.Items.Refresh();
            MessageBox.Show("Запись удалена");
        }

        private void tim()
        {
            var basis = Class1.conObj.Service.ToList();
            foreach (var item in basis)
            {
                if (item.Discount > 0)
                {
                    item.Discountskid = item.Discount + "% скидка";
                    item.oldcost = string.Format("{0:#.00руб.}", item.Cost);
                    item.Cost_stat = (decimal)(((double)item.Cost) * ((100 - item.Discount) / 100));
                    item.Foreground = "#00FF7F";


                }
                else
                {

                    item.Foreground = null;
                    item.Discountskid = null;
                    item.Cost_stat = item.Cost;
                }
                item.DurationInMin = item.DurationInSeconds / 60;

            }
            serviceList.ItemsSource = basis;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tim();
            new Add().ShowDialog();

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            new Zapis().Show();
        }

        private void serviceList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = ((FrameworkElement)e.OriginalSource).DataContext as Service;
            if (item != null)
            {
                var w = new Show_Zapis();
                w.init(item);
                w.ShowDialog();
            }


            //var w = new Show_Zapis();
            //w.init(((ListBox)sender).DataContext as Service);
            //w.Show();

        }
    }
}
