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
using System.Data.SqlClient;
using System.Data.Common;

namespace BD_Proiect.Gallery
{
    /// <summary>
    /// Interaction logic for PaintingsPage.xaml
    /// </summary>
    public partial class PaintingsPage : UserControl
    {
        public Action<int> backToExpositions;
        public Action<int> newOrderPage;
        public Action backToGallery;

        static string connectionString = "Server=.;Database=BD_Proiect;Trusted_Connection=true";
        SqlConnection connection = new SqlConnection(connectionString);
        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();

        public PaintingsPage()
        {
            InitializeComponent();
        }

        public void table(int expositionID)
        {
            SqlCommand CMD = new SqlCommand(string.Format("SELECT O.ID_Opera, O.ID_Autor, O.Nume,O.An, O.[Pret(RON)],O.Detalii FROM Opere_De_Arta AS O INNER JOIN Expozitii_Opere_De_Arta AS EO ON O.ID_Opera = EO.ID_Opera WHERE EO.ID_Expozitie = {0}", expositionID), connection);
            List<Opera> expozitii = new List<Opera>();

            connection.Open();

            CMD.Connection = connection;

            DbDataReader db = CMD.ExecuteReader();
            while (db.Read())
            {
                expozitii.Add(new Opera()
                {
                    ID = (int)db.GetValue(0),
                    IDAutor = db.GetValue(1).ToString(),
                    Name = db.GetValue(2).ToString(),
                    An = db.GetValue(3).ToString(),
                    Pret=db.GetValue(4).ToString(),
                    Detalii=db.GetValue(5).ToString()
                });
            }
            PaintingsDataGrid.ItemsSource = expozitii;

            connection.Close();
        }

        private void ExpositionsButton_Click(object sender, RoutedEventArgs e)
        {
            backToExpositions(-1);
        }

        private void GallerysButton_Click(object sender, RoutedEventArgs e)
        {
            backToGallery();
        }

        private void PaintingsDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            Opera exposition = (Opera)PaintingsDataGrid.SelectedItem;
            newOrderPage(exposition.ID);
        }
    }
    public class Opera
    {
        public int ID { get; set; }
        public string IDAutor { get; set; }
        public string Name { get; set; }
        public string An { get; set; }
        public string Pret { get; set; }

        public string Detalii { get; set; }
    }
}
