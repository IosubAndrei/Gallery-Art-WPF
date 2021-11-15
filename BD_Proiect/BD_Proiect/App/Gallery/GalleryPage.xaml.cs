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
    /// Interaction logic for GalleryPage.xaml
    /// </summary>
    public partial class GalleryPage : UserControl
    {
        public Action backToStatUp;
        public Action<int> getExpositions;

        public GalleryPage()
        {
            InitializeComponent();
        }

        private void Gallerys_Button_Click(object sender, RoutedEventArgs e)
        {
            backToStatUp();
        }

        private void GalleryDataGrid_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            int galleryID = 1;
            getExpositions(galleryID);
        }
    }
}
