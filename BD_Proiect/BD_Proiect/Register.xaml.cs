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

namespace BD_Proiect
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Server=.;Database=BD_Proiect;Trusted_Connection=true");

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(txtUsername.Text == "" && txtPassword.Text == "" && txtConfirmPassword.Text=="")
            {
                MessageBox.Show("Username and Password fields are empty!", "Sign Up Failed", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (txtPassword.Text == txtConfirmPassword.Text)
            {
                con.Open();
                string register = "INSERT INTO Users VALUES ('" + txtUsername.Text + "','" + txtPassword.Text + "')";
                con.Close();
            }
        }
    }
}
