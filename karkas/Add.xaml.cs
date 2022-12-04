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
    /// Логика взаимодействия для Add.xaml
    /// </summary>
    public partial class Add : Window
    {
        private Service sr;
        public Add()
        {
            InitializeComponent();
        }


        


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sr = new Service(); 
            MessageBox.Show("Услуга добавлена");
            sr.Title = name_ysl.Text;
            sr.Cost = decimal.Parse(mon.Text);
            sr.DurationInSeconds = int.Parse(min.Text);
            sr.MainImagePath = photo.Text;
            sr.Discount = double.Parse(skidka.Text);
            Class1.conObj.Service.Add(sr);
            Class1.conObj.SaveChanges();
            Close();

        }

       

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Сюда можно импортировать картинку");
        }
    }
}
