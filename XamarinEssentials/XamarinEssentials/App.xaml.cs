using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
/* Author: James Anderson		Course: NMAD.261.01
Date: Spring 2022
Purpose of the file: Study Xamarin Essentials
Caveats: */
namespace XamarinEssentials
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var nav = new NavigationPage(new MainPage());
            nav.BarBackgroundColor = Color.FromHex("#292929");
            nav.BarTextColor = Color.FromHex("#F4B5FF");
            MainPage = nav;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
