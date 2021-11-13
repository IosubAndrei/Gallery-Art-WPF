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

            //loginPage
            loginPage.registerButtonAction += openRegisterPage;
            loginPage.loginButtonAction += openMainPage;
            loginPage.exitButtonAction += closeApp;

            //registerPage
            registerPage.backToLoginButtonAction += closeRegisterPage;
            registerPage.backToLoginButtonAction += openLoginPage;
            registerPage.exitButtonAction += closeApp;

            //mainPageeee
            mainPage.exitButtonAction += closeApp;
            mainPage.signOutButtonAction += openLoginPage;
            mainPage.signOutButtonAction += closeApp;
        }

        private void openLoginPage()
        {
            loginPage.Show();
        }

        private void openRegisterPage()
        {
            loginPage.Hide();
            registerPage.Show();
        }
        private void closeRegisterPage()
        {
            registerPage.Hide();
            loginPage.Show();
        }
        private void openMainPage()
        {
            loginPage.Close();
            registerPage.Close();
            mainPage.Show();
        }
        private void closeApp()
        {
            loginPage.Close();
            mainPage.Close();
            registerPage.Close();
            this.Close();
        }

    }
}
