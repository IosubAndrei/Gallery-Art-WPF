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
    /// Interaction logic for OrderDetailsPage.xaml
    /// </summary>
    public partial class OrderDetailsPage : UserControl
    {
        public Action acceptOrder;
        public Action<int> declineOrder;

        static string connectionString = "Server=.;Database=BD_Proiect;Trusted_Connection=true";
        SqlConnection connection = new SqlConnection(connectionString);
        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();
        public OrderDetailsPage(int userID,int operaID)
        {
            SqlCommand CMD = new SqlCommand();

            InitializeComponent();

            connection.Open();

            CMD.Connection = connection;
            CMD.CommandText = "SELECT O.ImageURL FROM Opere_De_Arta AS O WHERE O.ID_Opera=@IDOpera";
            CMD.Parameters.AddWithValue("@IDOpera", operaID);

            DbDataReader db = CMD.ExecuteReader();
            while (db.Read())
            {
                ImageURL = db.GetValue(0).ToString();
            }

            connection.Close();

            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(ImageURL, UriKind.Absolute);
            bitmap.EndInit();

            ImageGrid.Source = bitmap;
        }

        public string ImageURL { get; set; }

        private void declineButton_Click(object sender, RoutedEventArgs e)
        {
            declineOrder(-1);
        }
    }
}
