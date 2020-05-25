using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Content;
using Xamarin.Forms;
using Plugin.CurrentActivity;

namespace App2.Droid
{
    [Activity(Label = "App2", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            if (!isPad(this))
            {
                RequestedOrientation = ScreenOrientation.Portrait;
            }
            else
            {
                RequestedOrientation = ScreenOrientation.Portrait;
            }
            CrossCurrentActivity.Current.Activity = this;
            base.OnCreate(savedInstanceState);

            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }

        public static bool isPad(Context context)
        {
            return (context.Resources.Configuration.ScreenLayout & Android.Content.Res.ScreenLayout.SizeMask) >= Android.Content.Res.ScreenLayout.SizeLarge;
        }

        public override void OnConfigurationChanged(Android.Content.Res.Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);

            switch (newConfig.Orientation)
            {
                case Android.Content.Res.Orientation.Portrait:
                    switch (Device.Idiom)
                    {
                        case TargetIdiom.Phone:
                            LockRotation(Orientation.Vertical);
                            break;
                        case TargetIdiom.Tablet:
                            LockRotation(Orientation.Horizontal);
                            break;
                    }
                    break;
                case Android.Content.Res.Orientation.Landscape:
                    switch (Device.Idiom)
                    {
                        case TargetIdiom.Phone:
                            LockRotation(Orientation.Vertical);
                            break;
                        case TargetIdiom.Tablet:
                            LockRotation(Orientation.Horizontal);
                            break;
                    }
                    break;
            }
        }
        private void LockRotation(Orientation orientation)
        {
            switch (orientation)
            {

                case Orientation.Vertical:
                    RequestedOrientation = ScreenOrientation.Portrait;
                    break;
                case Orientation.Horizontal:
                    RequestedOrientation = ScreenOrientation.Landscape;
                    break;
                    
            }
        }

        
    }
}