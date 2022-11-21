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
using System.Data.SqlClient;
using karkas.AppDataFile;
using System.Collections.ObjectModel;
using System.Security.Policy;

namespace karkas
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            Class1.conObj = new Mihailova_demoEntities2();
            var basis = Class1.conObj.Service.ToList();
            foreach (var item in basis) {
                if (item.Discount > 0)
                {
                    item.Discountskid = item.Discount + "% скидка";
                    item.oldcost = string.Format("{0:#.00руб.}", item.Cost);
                    item.Cost = (decimal)(((double)item.Cost) * ((100 - item.Discount) / 100));
                }
            }
                
            
            serviceList.ItemsSource = basis;
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Admin().Show();
            Close();
        }

       
    }
}
