using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BD_Proiect
{
    class MasterUserControlGallery
    {
        public MasterUserControlGallery(Grid mainGrid)
        {
            newStartUp(mainGrid);
        }

        void newGallerySearch()
        {
            Gallery.GalleryPage galleryPage = new Gallery.GalleryPage();
            Gallery.ExpositionsPage expositionsPage = new Gallery.ExpositionsPage();
            Gallery.PaintingsPage paintingsPage = new Gallery.PaintingsPage();
        }

        void newStartUp(Grid mainGrid)
        {
            StartUpPage startUpPage = new StartUpPage();
            mainGrid.Children.Clear();
            mainGrid.Children.Add(startUpPage);
        }

        void newGallery(Grid mainGrid)
        {
            mainGrid.Children.Clear();
            mainGrid.Children.Add(galleryPage);
            galleryPage.backToStatUp += newStartUp;
        }

        void newExpositions(Grid mainGrid)
        {
            
            mainGrid.Children.Clear();
            mainGrid.Children.Add(expositionsPage);
        }

        void newPaintings(Grid mainGrid)
        {
            
            mainGrid.Children.Clear();
            mainGrid.Children.Add(paintingsPage);
        }
    }
}
