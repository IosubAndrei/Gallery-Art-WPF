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
        public Action backToLoginButtonAction;

        public Register()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server=.;Database=BD_Proiect;Trusted_Connection=true");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "" && txtPassword.Text == "" && txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty!", "Sign Up Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txtPassword.Text == txtConfirmPassword.Text)
            {
                con.Open();
                string register = "INSERT INTO Users VALUES ('" + txtUsername.Text + "','" + txtPassword.Text + "')";
                cmd = new SqlCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Passwords does not match, please re-enter", "Registration Failed", MessageBoxButton.OK, MessageBoxImage.Error);
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtPassword.Focus();
            }
        }
        
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";

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
            passwordBox.Password = txtPassword.Text;
            passwordBox.Visibility = System.Windows.Visibility.Visible;
            txtPassword.Visibility = System.Windows.Visibility.Collapsed;

            confirmPasswordBox.Password = txtConfirmPassword.Text;
            confirmPasswordBox.Visibility = System.Windows.Visibility.Visible;
            txtConfirmPassword.Visibility = System.Windows.Visibility.Collapsed;

            passwordBox.Focus();
        }

        private void passwordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            {
                ((dynamic)this.DataContext).SecurePassword = ((PasswordBox)sender).Password;
            }
        }

        private void BackToLogin_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            backToLoginButtonAction();
        }

    }
}