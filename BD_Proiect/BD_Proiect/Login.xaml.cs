using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace BD_Proiect
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Action registerButtonAction;
        public Action loginButtonAction;

        static string connectionString = "Server=.;Database=BD_Proiect;Trusted_Connection=true";
        SqlConnection connection = new SqlConnection(connectionString);
        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();

        string currentTableName = "";

        public SecureString SecurePassword { private get; set; }
        public Login()
        {
            InitializeComponent();

            connection.Open();

            DataTable dt = connection.GetSchema("Tables");
            List<string> tables = new List<string>();

            foreach(DataRow row in dt.Rows)
            {
                tables.Add((string)row[2]);
            }
            connection.Close();
        }

        private void checkbxShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            txtPassword.Text = passwordBox.Password;
            passwordBox.Visibility = System.Windows.Visibility.Collapsed;
            txtPassword.Visibility = System.Windows.Visibility.Visible;

            txtPassword.Focus();
        }

        private void checkbxShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            passwordBox.Password = txtPassword.Text;
            passwordBox.Visibility = System.Windows.Visibility.Visible;
            txtPassword.Visibility = System.Windows.Visibility.Collapsed;

            passwordBox.Focus();
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if(this.DataContext != null)
            {
                ((dynamic)this.DataContext).SecurePassword = ((PasswordBox)sender).Password;
            }
        }

        private void registerButton_Click(object sender, RoutedEventArgs e)
        {
            registerButtonAction();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            loginButtonAction();
        }
    }
}
