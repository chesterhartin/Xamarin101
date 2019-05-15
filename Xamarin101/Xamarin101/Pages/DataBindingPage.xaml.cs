using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Xamarin101.Pages
{
    public partial class DataBindingPage : ContentPage
    {
        public DataBindingPage()
        {
            InitializeComponent();

            // OLD WAY
            //welcomeLabel.Text = "this is the old way :[";


            #region NEW WAY

            //// ViewModel to data bind to
            var viewModel = new DataBindingPageViewModel
            {
                LabelText = "This is the new way",
                FrameColor = Color.LightGreen,
                IsItSaturday = DateTime.Now,
                IsSwitchOn = true
            };

            // Have to set the BindingContext of the Page
            this.BindingContext = viewModel;

            #endregion NEW WAY
        }
    }

    // Class to illustrate data binding. 
    public class DataBindingPageViewModel
    {
        public string LabelText { get; set; }

        public Color FrameColor { get; set; }

        public bool IsSwitchOn { get; set; }


        // Example of type mismatch
        public DateTime IsItSaturday { get; set; }
    }
}
