using System;
using System.Collections.Generic;
using System.Data;
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

namespace BD_Proiect
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static string connectionString = "Server=.;Database=BD_Proiect;Trusted_Connection=true";
        SqlConnection connection = new SqlConnection(connectionString);
        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();

        public MainWindow()
        {
            InitializeComponent();
            bool isVisible = false;
            if(isVisible)
                Employee_Button.Visibility = Visibility.Visible;
            else
                Employee_Button.Visibility = Visibility.Collapsed;
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Employee_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Commands_Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Gallerys_Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
