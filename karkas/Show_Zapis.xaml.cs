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
    /// Логика взаимодействия для Show_Zapis.xaml
    /// </summary>
    public partial class Show_Zapis : Window
    {
        public Show_Zapis()
        {
            InitializeComponent();
            
        }
        internal void init(Service sr )
        {
            showList.ItemsSource = sr.ClientService;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var R_S = ((Button)sender).DataContext as ClientService;
            Class1.conObj.ClientService.Remove(R_S);
            Class1.conObj.SaveChanges();
            (showList.ItemsSource as ICollection<ClientService>).Remove(R_S);
            showList.Items.Refresh();
        }
    }
}
