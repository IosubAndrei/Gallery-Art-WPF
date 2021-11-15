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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BD_Proiect.Gallery
{
    /// <summary>
    /// Interaction logic for ExpositionsPage.xaml
    /// </summary>
    public partial class ExpositionsPage : UserControl
    {
        public Action backToGallery;
        public Action getPaintings;

        public ExpositionsPage()
        {
            InitializeComponent();
        }

        private void Gallerys_Button_Click(object sender, RoutedEventArgs e)
        {
            backToGallery();
        }

        private void ExpositionsDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            getPaintings();
        }
    }
}
