﻿using System;
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
using System.Windows.Threading;

namespace karkas
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hello h = new Hello();
            
        public MainWindow()
        {
            InitializeComponent();
            Class1.conObj = new Mihailova_demoEntities2();
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(5);
            timer.Tick += UpdateData;
            timer.Start();
            h.ShowDialog();
            tim();
            
        }

        private void UpdateData(object sender, EventArgs e)
        {
            h.Close();
            
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
                    item.Cost_stat = item.Cost;
                }
                item.DurationInMin = item.DurationInSeconds / 60;
               
            }


           
            serviceList.ItemsSource = basis;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {

           
            new kod_pr().Show();
         
            Close();
        }

       
    }
}
