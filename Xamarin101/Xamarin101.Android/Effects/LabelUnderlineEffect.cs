using System;
using System.Diagnostics;
using System.Linq;
using Android.Graphics;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin101.Droid.Effects;

[assembly: ResolutionGroupName("Xamarin101")] // this is only needed on one effect
[assembly: ExportEffect(typeof(LabelUnderlineEffect), "LabelUnderlineEffect")]
namespace Xamarin101.Droid.Effects
{
    public class LabelUnderlineEffect : PlatformEffect
    {
        // Apply your customization here, along w/ exception handling
        protected override void OnAttached()
        {
            try
            {
                // Get an instance of the attached effect, so we can get the parameter values to use.
                var effect = (Xamarin101.Effects.LabelUnderlineEffect)Element.Effects.FirstOrDefault(e => e is Xamarin101.Effects.LabelUnderlineEffect);

                if (effect != null)
                {
                    var textView = (TextView)Control;
                    textView.PaintFlags |= PaintFlags.UnderlineText;

                }
                else
                {
                    Debug.WriteLine("Oops, unable to find a LabelUnderlineEffect effect attached to the control.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Oops, unable to set property on attached control. {ex.Message}");
            }
        }


        // Cleanup, deregister the event handliner
        protected override void OnDetached()
        {
            return;
        }
    }
}
