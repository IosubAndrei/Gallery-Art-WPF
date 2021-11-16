using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Configuration;
using System.Data.Common;

namespace BD_Proiect
{
    public partial class Register : Window
    {
        public Action<Register> backToLoginButtonAction;
        public Action<Register> exitButtonAction;
        public Action<Register> registerButtonAction;

        SqlConnection con = new SqlConnection("Server=.;Database=BD_Proiect;Trusted_Connection=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        int esteAngajat = 0;

        public Register()
        {
            InitializeComponent();
        }

        public void reset()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";

            passwordBox.Password = "";
            confirmPasswordBox.Password = "";
            
            checkbxAngajat.IsChecked = false;
            checkbxShowPassword.IsChecked = false;
        }

        private bool verify(string username)
        {
            SqlCommand CMD = new SqlCommand(string.Format("SELECT * FROM Users WHERE Username= '{0}'", username), con);

            con.Open();

            CMD.Connection = con;

            DbDataReader db = CMD.ExecuteReader();
            if (db.Read())
            {
                return false;
            }
            con.Close();

            return true; 
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SqlCommand insertCMD = new SqlCommand();

            string username = txtUsername.Text;
            string password = passwordBox.Password.ToString();

            if (txtUsername.Text == "" && passwordBox.Password == "" && confirmPasswordBox.Password == "" || passwordBox.Password == "" || passwordBox.Password == "" && confirmPasswordBox.Password == "" || txtUsername.Text == "")
            {
                MessageBox.Show("Username or Password fields are empty!", "Sign Up Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (!verify(username))
                {

                    MessageBox.Show("User already exists!", "Sign Up Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                    reset();
                }
                else if (passwordBox.Password == confirmPasswordBox.Password && txtPassword.Text == txtConfirmPassword.Text)
                    {
                        con.Open();
                        insertCMD.Connection = con;
                        insertCMD.CommandText = "INSERT INTO Users VALUES ('" + username + "','" + password + "','" + esteAngajat + "')";
                        insertCMD.ExecuteNonQuery();
                        con.Close();

                        reset();

                        MessageBox.Show("Your Account has been Successfully Created!", "Registration Success!", MessageBoxButton.OK, MessageBoxImage.Information);
                        registerButtonAction(this);
                    }
                    else
                    {
                        MessageBox.Show("Passwords does not match, please re-enter", "Registration Failed!", MessageBoxButton.OK, MessageBoxImage.Error);

                        reset();

                        txtUsername.Focus();
                    }
            }
            
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            reset();

            txtUsername.Focus();
        }

        private void checkbxShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            txtPassword.Text = passwordBox.Password;
            passwordBox.Visibility = System.Windows.Visibility.Collapsed;
            txtPassword.Visibility = System.Windows.Visibility.Visible;

            txtConfirmPassword.Text = confirmPasswordBox.Password;
            confirmPasswordBox.Visibility = System.Windows.Visibility.Collapsed;
            txtConfirmPassword.Visibility = System.Windows.Visibility.Visible;

            txtPassword.Focus();
        }

        private void checkbxShowPassword_Unchecked(object sender, RoutedEventArgs e)
        {
            passwordBox.Password = txtConfirmPassword.Text;
            passwordBox.Visibility = System.Windows.Visibility.Visible;
            txtConfirmPassword.Visibility = System.Windows.Visibility.Collapsed;

            confirmPasswordBox.Password = txtConfirmPassword.Text;
            confirmPasswordBox.Visibility = System.Windows.Visibility.Visible;
            txtConfirmPassword.Visibility = System.Windows.Visibility.Collapsed;

            confirmPasswordBox.Focus();
        }

        private void BackToLogin_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            backToLoginButtonAction(this);
        }

        private void RegisterPage1_Closed(object sender, EventArgs e)
        {
            exitButtonAction(this);
        }

        private void checkbxAngajat_Checked(object sender, RoutedEventArgs e)
        {
            if(checkbxAngajat.IsChecked == true)
            {
                esteAngajat = 1;
            }
        }

        private void checkbxAngajat_Unchecked(object sender, RoutedEventArgs e)
        {
            if(checkbxAngajat.IsChecked == false)
            {
                esteAngajat = 0;
            }
        }
    }
}