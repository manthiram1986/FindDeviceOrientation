using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    //[DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
        }
        //void OnSizeChanged(object sender, EventArgs e)
        //{
        //    if (Height > Width)
        //    {

        //    }
        //    else
        //    {

        //    }
        //    image.Source = ImageSource.FromFile(Height > Width ? "portrait.jpg" : "landscape.jpg");
        //}

        private void btnsubmit_Clicked(object sender, EventArgs e)
        {
            Dummy page = new Dummy();
            Application.Current.MainPage.Navigation.PushAsync(page);
        }
    }
}
