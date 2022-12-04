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
    /// Логика взаимодействия для Zapis.xaml
    /// </summary>
    public partial class Zapis : Window
    {
        public Zapis()
        {            
            InitializeComponent();
            var kl = Class1.conObj.Client.ToList();
            var us = Class1.conObj.Service.ToList();
            var kl_us = Class1.conObj.ClientService.ToList();
            fio.ItemsSource = kl;
            serv.ItemsSource = us;
            fio.SelectedIndex = 0;
            serv.SelectedIndex = 0;
            clock.SelectedIndex = 0;
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

        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = calendar1.SelectedDate;

            MessageBox.Show(selectedDate.Value.Date.ToShortDateString());
        }
    }
}
