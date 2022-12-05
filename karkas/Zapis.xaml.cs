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
          
        }




        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var c_s = new ClientService();
            c_s.Client = fio.SelectedItem as Client;
            c_s.Service = serv.SelectedItem as Service;
            var vr = clock.Text.Split(':');
            var day = (DateTime)calendar1.SelectedDate;
            c_s.StartTime = new DateTime(day.Year, day.Month, day.Day, int.Parse(vr[0]), int.Parse(vr[1]),0);
            
            c_s.Comment = kmn.Text;
            Class1.conObj.ClientService.Add(c_s);
            Class1.conObj.SaveChanges();
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
