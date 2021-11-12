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
using System.Windows.Shapes;

namespace BD_Proiect
{
    /// <summary>
    /// Interaction logic for MasterWindow.xaml
    /// </summary>
    public partial class MasterWindow : Window
    {
        MainWindow mainPage = new MainWindow();
        Register registerPage = new Register();
        Login loginPage = new Login();

        public MasterWindow()
        {
            InitializeComponent();
            this.Hide();
            loginPage.Show();
            loginPage.registerButtonAction += openRegisterPage;
            loginPage.loginButtonAction += openMainPage;
            registerPage.backToLoginButtonAction += closeRegisterPage;
            registerPage.backToLoginButtonAction += openLoginPage;
            mainPage.exitButtonAction += closeMainPage;
        }

        public void openLoginPage()
        {
            loginPage.Show();
        }

        public void openRegisterPage()
        {
            loginPage.Hide();
            registerPage.Show();
        }
        public void closeRegisterPage()
        {
            registerPage.Hide();
            loginPage.Show();
        }
        public void openMainPage()
        {
            loginPage.Close();
            registerPage.Close();
            mainPage.Show();
        }
        public void closeMainPage()
        {
            mainPage.Close();
            this.Close();
        }

    }
}
