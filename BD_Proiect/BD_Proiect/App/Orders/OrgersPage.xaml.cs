using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
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

namespace BD_Proiect.Orders
{
    /// <summary>
    /// Interaction logic for OrgersPage.xaml
    /// </summary>
    public partial class OrgersPage : UserControl
    {
        static string connectionString = "Server=.;Database=BD_Proiect;Trusted_Connection=true";
        SqlConnection connection = new SqlConnection(connectionString);
        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();

        public OrgersPage(int userID)
        {
            InitializeComponent();

            SqlCommand CMD = new SqlCommand();
            List<Orders> comenzi = new List<Orders>();

            connection.Open();

            CMD.Connection = connection;
            CMD.CommandText = "SELECT O.Nume,C.Data_Livrare,C.Data_Plasare,O.An,O.[Pret(RON)],O.Detalii," +
                "CONCAT(CL.Nume,CL.Prenume),CL.Numar_Telefon,CL.Adresa " +
                "FROM Comenzi AS C INNER JOIN Users AS U ON C.ID_User=U.ID INNER JOIN Comenzi_Opere_De_Arta AS CO" +
                " ON C.ID_Comanda=CO.ID_Comenzi INNER JOIN Opere_De_Arta AS O" +
                " ON CO.ID_Opera=O.ID_Opera INNER JOIN Clienti AS CL ON C.ID_Client=CL.ID_Client WHERE U.ID=@userID";
            CMD.Parameters.AddWithValue("@userID", userID);

            DbDataReader db = CMD.ExecuteReader();
            while (db.Read())
            {
                comenzi.Add(new Orders()
                {
                    NameOpera=db.GetValue(0).ToString(),
                    DeliveryDate=(DateTime)db.GetValue(1),
                    PlacementDate = (DateTime)db.GetValue(2),
                    Year = db.GetValue(3).ToString(),
                    Price = db.GetValue(4).ToString(),
                    Details = db.GetValue(5).ToString(),
                    FullName = db.GetValue(6).ToString(),
                    Phone_Number = db.GetValue(7).ToString(),
                    Address = db.GetValue(8).ToString()
                }) ;
            }

            OrdersDataGrid.ItemsSource = comenzi;
            connection.Close();
        }
    }

    public class Orders
    {
        public string NameOpera { get; set; }
        public DateTime DeliveryDate { get; set; }
        public DateTime PlacementDate { get; set; }
        public string Year { get; set; }
        public string Price { get; set; }
        public string Details { get; set; }
        public string FullName { get; set; }
        public string Phone_Number { get; set; }
        public string Address { get; set; }
    }
}
