using karkas.AppDataFile;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Логика взаимодействия для Edit.xaml
    /// </summary>
    public partial class Edit : Window
    {
        private Service sr;
        public Edit()
        {
            InitializeComponent();
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            sr.Title = name.Text;
            sr.DurationInSeconds = int.Parse(dlit.Text)*60;
            sr.Cost = decimal.Parse(mon.Text);
            sr.MainImagePath = photo.Text;
            sr.Discount = double.Parse(skid.Text);
            Class1.conObj.Service.AddOrUpdate();
            Class1.conObj.SaveChanges();
           
            MessageBox.Show("Услуга изменена");
            Close();
        }

        public void init(Service sr)
        {
            this.sr = sr;
            name.Text = sr.Title;
            dlit.Text = (sr.DurationInSeconds / 60).ToString();
            mon.Text = ((int)(sr.Cost)).ToString();
            photo.Text = sr.MainImagePath;
            skid.Text = sr.Discount.ToString();


        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Close();
        }
    }
}
