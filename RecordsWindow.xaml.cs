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
using LearnApp.Classes;

namespace LearnApp
{
    /// <summary>
    /// Логика взаимодействия для RecordsWindow.xaml
    /// </summary>
    public partial class RecordsWindow : Window
    {
        public RecordsWindow()
        {
            InitializeComponent();
            List<ClientService> cs = DataBase.db.ClientService.ToList();
            cs.Sort((x, y) => x.StartTime.CompareTo(y.StartTime));
            cs.Reverse();
            DgServices.ItemsSource = cs;
        }
    }
}
