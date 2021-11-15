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
        Grid masterGrid;
        Gallery.GalleryPage galleryPage;
        Gallery.ExpositionsPage expositionsPage;
        Gallery.PaintingsPage paintingsPage;

        public MasterUserControlGallery(Grid mainGrid)
        {
            masterGrid = mainGrid;
            newStartUp();
        }

        public void newGallerySearch()
        {
            galleryPage = new Gallery.GalleryPage();
            expositionsPage = new Gallery.ExpositionsPage();
            paintingsPage = new Gallery.PaintingsPage();
            newGallery();
        }

        private void newStartUp()
        {
            StartUpPage startUpPage = new StartUpPage();
            masterGrid.Children.Clear();
            masterGrid.Children.Add(startUpPage);
        }

        void newGallery()
        {
            masterGrid.Children.Clear();
            masterGrid.Children.Add(galleryPage);
            galleryPage.backToStatUp += newStartUp;
            galleryPage.getExpositions += newExpositions;
        }

        void newExpositions(int galleryID)
        {
            expositionsPage.table(galleryID);
            masterGrid.Children.Clear();
            masterGrid.Children.Add(expositionsPage);
            expositionsPage.backToGallery += newGallery;
            expositionsPage.getPaintings += newPaintings;
        }

        void newPaintings(int expositionID)
        {
            paintingsPage.table(expositionID);
            masterGrid.Children.Clear();
            masterGrid.Children.Add(paintingsPage);
            paintingsPage.backToExpositions += newExpositions;
            paintingsPage.backToGallery += newGallery;
        }
    }
}
