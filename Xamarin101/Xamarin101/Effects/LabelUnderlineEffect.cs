using Xamarin.Forms;

namespace Xamarin101.Effects
{
    /// <summary>
    /// Underline effect for labels
    /// </summary>
    public class LabelUnderlineEffect : RoutingEffect
    {
        public LabelUnderlineEffect() : base("Xamarin101.LabelUnderlineEffect")
        {
        }

        // A parameter that we can pass into the effect. Use black as the default color.
        public Color LineColor { get; set; } = Color.Black;
    }
}
