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

namespace BD_Proiect
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Action<MainWindow> exitButtonAction;
        public Action ordersButtonAction;
        public Action<MainWindow> signOutButtonAction;

        MasterUserControlGallery masterUserControlGallery;
        int userID;
        int userType;

        static string connectionString = "Server=.;Database=BD_Proiect;Trusted_Connection=true";
        SqlConnection connection = new SqlConnection(connectionString);
        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();
        
        public MainWindow(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            setUser();
            masterUserControlGallery = new MasterUserControlGallery(mainGrid);
        }

        private void setUser()
        {
            SqlCommand selectCMD = new SqlCommand(string.Format("SELECT * FROM Users WHERE ID = {0}", userID), connection);
            connection.Open();
            selectCMD.Connection = connection;
            DbDataReader reader = selectCMD.ExecuteReader();
            reader.Read();
            UsernameLabel.Content = reader.GetValue(1).ToString();
            userType = Convert.ToInt32(reader.GetValue(3));
            connection.Close();

            if (userType == 1 || userType == 2)  
                Employee_Button.Visibility = Visibility.Visible;
            else
                Employee_Button.Visibility = Visibility.Collapsed;
            if (userType == 2)
                AdminButton.Visibility = Visibility.Visible;
            else
                AdminButton.Visibility = Visibility.Collapsed;
        }

        private void Commands_Button_Click(object sender, RoutedEventArgs e)
        {
            masterUserControlGallery.newOrders(userID);
        }

        private void Gallerys_Button_Click(object sender, RoutedEventArgs e)
        {
            masterUserControlGallery.newGallerySearch(userID);
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            exitButtonAction(this);
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            exitButtonAction(this);
        }

        private void Sign_Out_Button_Click(object sender, RoutedEventArgs e)
        {
            signOutButtonAction(this);
         }

        private void Employee_Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void AdminButton_Click(object sender, RoutedEventArgs e)
        {
            masterUserControlGallery.newAdminPage();
        }
    }
}
