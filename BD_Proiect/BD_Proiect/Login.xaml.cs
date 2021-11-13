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
        public int ID { get; set; }

        static string connectionString = "Server=.;Database=BD_Proiect;Trusted_Connection=true";
        SqlConnection connection = new SqlConnection(connectionString);
        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();

        string currentTableName = "Users";

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
            if (txtUsername.Text == "" && passwordBox.Password == "")
            {
                MessageBox.Show("Username and Password fields are empty!", "Sign Up Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                SqlCommand selectCMD = new SqlCommand(string.Format("SELECT {0} FROM {1} " +
                    "WHERE Username='" + txtUsername.Text + "' AND Password='" + txtPassword.Text + "'", ID,DS.Tables[currentTableName]));
                DA.SelectCommand = selectCMD;

                connection.Open();

                SqlCommandBuilder builder = new SqlCommandBuilder(DA);
                DA.Update(DS, currentTableName);


                connection.Close();

                if(ID != 0)
                {
                    MessageBox.Show("You have succesfully connected", "Registration Success", MessageBoxButton.OK, MessageBoxImage.Information);
                    loginButtonAction();
                }
                else
                {
                    MessageBox.Show("Passwords does not match, please re-enter", "Registration Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }
    }
}
