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
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
//
namespace BD_Proiect.Orders
{
    public partial class OrderDetailsPage : UserControl
    {
        static string connectionString = "Server=.;Database=BD_Proiect;Trusted_Connection=true";
        SqlConnection connection = new SqlConnection(connectionString);
        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();

        public Action acceptOrder;
        public Action<int> declineOrder;
        public OrderDetailsPage(int userID,int operaID)
        {
            InitializeComponent();

            SqlCommand clientiCMD = new SqlCommand();
            SqlCommand comenziCMD = new SqlCommand();

            connection.Open();

            string nume = numeTextBox.Text;
            string prenume = prenumeTextBox.Text;
            string phone = telefonTextBox.Text;
            string address = addressTextBox.Text;
            string loc = locTextBox.Text;

            clientiCMD.CommandText = "INSERT INTO Clienti VALUES ('"+nume+"', '"+prenume+"','"+phone+"','"+address+"','"+loc+"')";
        }

        private void declineButton_Click(object sender, RoutedEventArgs e)
        {
            declineOrder(-1);
        }
    }
}
