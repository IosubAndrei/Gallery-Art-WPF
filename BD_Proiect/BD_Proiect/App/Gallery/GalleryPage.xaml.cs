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

namespace BD_Proiect.Gallery
{
    /// <summary>
    /// Interaction logic for GalleryPage.xaml
    /// </summary>
    public partial class GalleryPage : UserControl
    {
        static string connectionString = "Server=.;Database=BD_Proiect;Trusted_Connection=true";
        SqlConnection connection = new SqlConnection(connectionString);
        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();
        string currentTableName = "Galerii";

        public Action backToStatUp;
        public Action getExpositions;

        public GalleryPage()
        {
            InitializeComponent();

            SqlCommand CMD = new SqlCommand();
            List<Galerie> galerii = new List<Galerie>();

            connection.Open();

            CMD.Connection = connection;
            CMD.CommandText = "SELECT ID_Galerie,Nume_Galerie,Adresa,Localitate,Cod_Postal FROM Galerii";

            DbDataReader db = CMD.ExecuteReader();
            while (db.Read())
            {
                galerii.Add(new Galerie()
                {
                    ID = (int)db.GetValue(0),
                    Name = db.GetValue(1).ToString(),
                    Adress = db.GetValue(2).ToString(),
                    Localitate = db.GetValue(3).ToString(),
                    Cod_Postal = (int)db.GetValue(4)
                }) ;
            }
            //DA.SelectCommand = CMD;
            //DS.Clear();
            //DA.Fill(DS, currentTableName);
            //GalleryDataGrid.ItemsSource = DS.Tables[currentTableName].DefaultView;
            GalleryDataGrid.ItemsSource = galerii;

            connection.Close();
        }

        private void Gallerys_Button_Click(object sender, RoutedEventArgs e)
        {
            backToStatUp();
        }

        private void GalleryDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            getExpositions();
        }
    }

    public class Galerie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string Localitate { get; set; }
        public int Cod_Postal { get; set; }
    }
}
