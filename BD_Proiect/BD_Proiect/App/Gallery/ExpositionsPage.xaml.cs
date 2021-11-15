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
    /// Interaction logic for ExpositionsPage.xaml
    /// </summary>
    public partial class ExpositionsPage : UserControl
    {
        public Action backToGallery;
        public Action<int> getPaintings;
        private bool isCreated = false;

        static string connectionString = "Server=.;Database=BD_Proiect;Trusted_Connection=true";
        SqlConnection connection = new SqlConnection(connectionString);
        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();

        public ExpositionsPage()
        {
            InitializeComponent();
        }

        public void table(int galleryID)
        {
            if(!isCreated)
            {
                SqlCommand sqlCommand = new SqlCommand(string.Format("Select Nume_Expozitie, Data_Inceput, Data_Sfarsit  FROM Expozitie WHERE ID_Galerie = {0}", 1), connection);

                DA.SelectCommand = sqlCommand;
                connection.Open();

                DS.Clear();
                DA.Fill(DS, "Expozitie");
                ExpositionsDataGrid.ItemsSource = DS.Tables["Expozitie"].DefaultView;
                connection.Close();
            }            
        }

        private void Gallerys_Button_Click(object sender, RoutedEventArgs e)
        {
            isCreated = false;
            backToGallery();
        }

        private void ExpositionsDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int expositionID = 1;
            getPaintings(expositionID);
        }
    }
}
