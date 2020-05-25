using Plugin.DeviceOrientation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Dummy : ContentPage
    {
        public Dummy()
        {
            InitializeComponent();
            //SizeChanged += OnSizeChanged;
            lblText.Text = CrossDeviceOrientation.Current.CurrentOrientation.ToString();
            DeviceDisplay.MainDisplayInfoChanged += OnMainDisplayInfoChanged;
        }
        private void OnMainDisplayInfoChanged(object sender, DisplayInfoChangedEventArgs e)
        {
            // throw new NotImplementedException();
            DisplayAlert("Info", e.DisplayInfo.Orientation.ToString() + " ", "OK");
        }



        void OnSizeChanged(object sender, EventArgs e)
        {
            if (Height > Width)
            {
                lblText.Text = "Protrait";
            }
            else
            {
                lblText.Text = "Landscape";
            }
        }
    }
}