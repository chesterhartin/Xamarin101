using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Xamarin101.Pages
{
    public partial class EffectsPage : ContentPage
    {
        public EffectsPage()
        {
            InitializeComponent();

            var viewModel = new EffectsPageViewModel
            {
                UnderlinedLabelText = "Am I underlined?..."
            };

            BindingContext = viewModel;
        }
    }

    // Class to illustrate data binding. This would normally be its own class file
    public class EffectsPageViewModel
    {
        public string UnderlinedLabelText { get; set; }
    }
}
