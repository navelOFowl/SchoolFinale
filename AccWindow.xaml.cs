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
    /// Логика взаимодействия для AccWindow.xaml
    /// </summary>
    public partial class AccWindow : Window
    {
        Service ServiceAcc = new Service();
        List<ClientService> CS = DataBase.db.ClientService.ToList();
        public AccWindow(Service lessAcc)
        {
            InitializeComponent();

            ServiceAcc = lessAcc;
            string name;
            TbTitle.Text = ServiceAcc.Title;
            TbDuration.Text = ServiceAcc.Duration;
            foreach(Client client in DataBase.db.Client)
            {
                name = client.FirstName + " " + client.LastName;
                CbUsers.Items.Add(name);
            }
            CbUsers.SelectedValuePath = "ID";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ClientService ms = new ClientService();
                ms.StartTime = (System.DateTime)DpDate.SelectedDate;
                ms.ServiceID = ServiceAcc.ID;
                ms.ClientID = CbUsers.SelectedIndex + 1;
                DataBase.db.ClientService.Add(ms);
                DataBase.db.SaveChanges();
                MessageBox.Show("Клиент записан");
            }
            catch
            {
                MessageBox.Show("Клиент не записан, проверьте ввод");
            }
}
    }
}
