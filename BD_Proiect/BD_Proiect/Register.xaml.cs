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

namespace BD_Proiect
{
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server=.;Database=BD_Proiect;Trusted_Connection=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
         
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtUsername.Text == "" && txtPassword.Password == "" && txtConfirmPassword.Password=="")
            {
                MessageBox.Show("Username and Password fields are empty!", "Sign Up Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txtPassword.Password == txtConfirmPassword.Password)
            {
                con.Open();
                string register = "INSERT INTO Users VALUES ('" + txtUsername.Text + "','" + txtPassword.Password + "')";
                cmd = new SqlCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Text = "";
                txtPassword.Password = "";
                txtConfirmPassword.Password = "";

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Passwords does not match, please re-enter", "Registration Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                txtPassword.Password = "";
                txtConfirmPassword.Password = "";
                txtPassword.Focus();
            }
        }

        private void checkbxShowPassword_Checked(object sender, RoutedEventArgs e)
        {
            if(checkbxShowPassword.IsChecked==true)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
                txtConfirmPassword.PasswordChar = '•';
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Password = "";
            txtConfirmPassword.Password = "";

            txtUsername.Focus();
        }

        private void backToLogin_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
