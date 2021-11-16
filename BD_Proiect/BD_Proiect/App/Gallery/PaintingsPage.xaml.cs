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

namespace BD_Proiect.Gallery
{
    /// <summary>
    /// Interaction logic for PaintingsPage.xaml
    /// </summary>
    public partial class PaintingsPage : UserControl
    {
        public Action<int> backToExpositions;
        public Action newOrderPage;
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
            SqlCommand sqlCommand = new SqlCommand(string.Format("SELECT Nume, [Pret(RON)] FROM Opere_De_Arta AS O INNER JOIN Expozitii_Opere_De_Arta AS EO ON O.ID_Opera = EO.ID_Opera WHERE EO.ID_Expozitie = {0}", expositionID), connection);

            DA.SelectCommand = sqlCommand;
            connection.Open();

            DS.Clear();
            DA.Fill(DS, "Opere_De_Arta");
            PaintingsDataGrid.ItemsSource = DS.Tables["Opere_De_Arta"].DefaultView;
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
            newOrderPage();
        }
    }
}
