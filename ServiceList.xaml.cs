﻿using LearnApp.Classes;
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

namespace LearnApp
{
    /// <summary>
    /// Логика взаимодействия для ServiceList.xaml
    /// </summary>
    public partial class ServiceList : Page
    {
        List<Service> ServiceStart = DataBase.db.Service.ToList();
        public ServiceList()
        {
            InitializeComponent();
            LVServices.ItemsSource = ServiceStart;
        }
    }
}
