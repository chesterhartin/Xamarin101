using System;
using System.Diagnostics;
using System.Linq;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Xamarin101.iOS.Effects;

[assembly: ResolutionGroupName("Xamarin101")] // this is only needed on one effect
[assembly: ExportEffect(typeof(LabelUnderlineEffect), "LabelUnderlineEffect")]
namespace Xamarin101.iOS.Effects
{        
    public class LabelUnderlineEffect : PlatformEffect
    {
        // Apply your customization here, along w/ exception handling
        protected override void OnAttached()
        {
            try
            {
                // Get an instance of the attached effect
                var effect = (Xamarin101.Effects.LabelUnderlineEffect)Element.Effects.FirstOrDefault(e => e is Xamarin101.Effects.LabelUnderlineEffect);

                if (effect != null)
                {
                    var label = (UILabel)Control;
                    var text = (NSMutableAttributedString)label.AttributedText;
                    var range = new NSRange(0, text.Length);

                    var passedInLineColor = effect.LineColor;

                    text.AddAttribute(UIStringAttributeKey.UnderlineStyle, NSNumber.FromInt32((int)NSUnderlineStyle.Single), range);
                    text.AddAttribute(UIStringAttributeKey.UnderlineColor, passedInLineColor.ToUIColor(), range);
                }
                else
                {
                    Debug.WriteLine("Unable to find a LabelUnderlineEffect.");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Unable to set property on attached control. {ex.Message}");
            }
        }

        // Do cleanup, etc 
        protected override void OnDetached()
        {
            return;
        }
    }
}
