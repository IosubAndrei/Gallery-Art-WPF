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
using System.Data.Common;
using System.Data.Linq.Mapping;

namespace BD_Proiect
{
    /// <summary>
    /// Interaction logic for AdminControlPage.xaml
    /// </summary>
    public partial class AdminControlPage : UserControl
    {
        appDBDataContext db=new appDBDataContext();
        string currentTableName;
        public AdminControlPage()
        {
            InitializeComponent();

            var datamodel = new AttributeMappingSource().GetModel(typeof(appDBDataContext));
            List<string> tables = new List<string>();
            foreach (var r in datamodel.GetTables())
                tables.Add(r.TableName.Substring(4));

            TableComboBox.DataContext = tables;
        }

        private void DeleteRecord_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete record?", "Confirmation", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                while (DataGrid.SelectedItems.Count >= 1)
                {
                    DataRowView drv = (DataRowView)DataGrid.SelectedItem;
                    drv.Row.Delete();
                    var selectie=DataGrid.SelectedItem;
                    
                }
                
                MessageBox.Show("Deleted Record!");
            }
        }

        private void TableComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            currentTableName = TableComboBox.SelectedItem.ToString();

            //SqlCommand selectCMD = new SqlCommand(string.Format("SELECT * FROM {0}", currentTableName), connection);

            //connection.Open();

            //DS.Clear();
            //DA.Fill(DS, currentTableName);
            //DataGrid.ItemsSource = DS.Tables[currentTableName].DefaultView;

            //connection.Close();
        }

        private void DataGrid_RowEditEnding(object sender, DataGridRowEditEndingEventArgs e)
        {
            Application.Current.Dispatcher.InvokeAsync(new Action(() =>
            {
                //connection.Open();

                //SqlCommandBuilder builder = new SqlCommandBuilder(DA);

                //DA.Update(DS, currentTableName);

                //connection.Close();
            }), DispatcherPriority.ContextIdle);
        }
    }
}
