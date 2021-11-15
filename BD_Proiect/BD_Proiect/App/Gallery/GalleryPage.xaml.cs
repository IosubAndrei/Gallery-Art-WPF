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
        public Action<GalleryPage> backToStatUp;
        public GalleryPage()
        {
            InitializeComponent();
        }

        private void Gallerys_Button_Click(object sender, RoutedEventArgs e)
        {
            backToStatUp(this);
        }
    }
}
