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
                SqlCommand CMD = new SqlCommand(string.Format("Select ID_Expozitie, Nume_Expozitie, Data_Inceput, Data_Sfarsit  FROM Expozitie WHERE ID_Galerie = {0}", galleryID), connection);
                List<Expozitie> expozitii = new List<Expozitie>();

                connection.Open();

                CMD.Connection = connection;

                DbDataReader db = CMD.ExecuteReader();
                while (db.Read())
                {
                    expozitii.Add(new Expozitie()
                    {
                        ID = (int)db.GetValue(0),
                        Name = db.GetValue(1).ToString(),
                        dataInceput = db.GetValue(2).ToString(),
                        dataSfarsit = db.GetValue(3).ToString()
                    });
                }

                ExpositionsDataGrid.ItemsSource = expozitii;

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
            isCreated = true;
            Expozitie exposition = (Expozitie)ExpositionsDataGrid.SelectedItem;
            getPaintings(exposition.ID);
        }
    }
    public class Expozitie
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string dataInceput { get; set; }
        public string dataSfarsit { get; set; }
    }
}
