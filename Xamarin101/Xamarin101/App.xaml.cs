using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin101.Pages;

namespace Xamarin101
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //#1
            MainPage = new HelloWorld();

            // #2
            // Basic controls
            //MainPage = new MainPage();

            // #3 page styles
            //MainPage = new AbsoluteLayoutPage();
            //MainPage = new GridLayoutPage();

            // #4
           // MainPage = new DataBindingPage();

            // #5
            //MainPage = new PlatformSpecificsPage();
            //MainPage = new BehaviorsPage();
            //MainPage = new EffectsPage();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
