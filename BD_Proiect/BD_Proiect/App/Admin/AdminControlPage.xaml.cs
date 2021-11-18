using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Threading;
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
    /// Interaction logic for AdminControlPage.xaml
    /// </summary>
    public partial class AdminControlPage : UserControl
    {
        static string connectionString = "Server=.;Database=BD_Proiect;Trusted_Connection=true";
        SqlConnection connection = new SqlConnection(connectionString);
        DataSet DS = new DataSet();
        SqlDataAdapter DA = new SqlDataAdapter();
        string currentTableName = "";
        public AdminControlPage()
        {
            InitializeComponent();

            connection.Open();

            DataTable dt = connection.GetSchema("Tables");
            List<string> tables = new List<string>();

            foreach (DataRow row in dt.Rows)
            {
                tables.Add((string)row[2]);
            }
            connection.Close();

            TableComboBox.DataContext = tables;
        }

        private void AddRecord_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ModifyRecord_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteRecord_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete record?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                while (DataGrid.SelectedItems.Count >= 1)
                {
                    DataRowView drv = (DataRowView)DataGrid.SelectedItem;
                    drv.Row.Delete();
                }

                connection.Open();

                SqlCommandBuilder builder = new SqlCommandBuilder(DA);
                DA.Update(DS, currentTableName);

                connection.Close();

                MessageBox.Show("Deleted Record!");
            }
        }

        private void TableComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentTableName = TableComboBox.SelectedItem.ToString();

            SqlCommand selectCMD = new SqlCommand(string.Format("SELECT * FROM {0}", currentTableName), connection);

            DA.SelectCommand = selectCMD;

            connection.Open();

            DS.Clear();
            DA.Fill(DS, currentTableName);
            DataGrid.ItemsSource = DS.Tables[currentTableName].DefaultView;

            connection.Close();
        }

        private void DataGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            Application.Current.Dispatcher.InvokeAsync(new Action(() =>
            {
                connection.Open();

                SqlCommandBuilder builder = new SqlCommandBuilder(DA);

                DA.Update(DS, currentTableName);

                connection.Close();
            }), DispatcherPriority.ContextIdle);
        }
    }
}
