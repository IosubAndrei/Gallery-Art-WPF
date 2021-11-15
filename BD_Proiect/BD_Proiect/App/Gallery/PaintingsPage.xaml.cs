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
    /// Interaction logic for PaintingsPage.xaml
    /// </summary>
    public partial class PaintingsPage : UserControl
    {
        public Action backToExpositions;
        public Action backToGallery;

        public PaintingsPage()
        {
            InitializeComponent();
        }

        private void ExpositionsButton_Click(object sender, RoutedEventArgs e)
        {
            backToExpositions();
        }

        private void GallerysButton_Click(object sender, RoutedEventArgs e)
        {
            backToGallery();
        }
    }
}
