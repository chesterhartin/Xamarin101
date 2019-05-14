using Xamarin.Forms;

namespace Xamarin101.Behaviors
{
    /// <summary>
    /// Restrict the number of characters in an entry 
    /// </summary>
    public class EntryLengthValidatorBehavior : Behavior<Entry>
    {
        public EntryLengthValidatorBehavior(int maxLength)
        {
            this.MaxLength = maxLength;
        }

        public int MaxLength { get; set; }


        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);
            bindable.TextChanged += this.OnEntryTextChanged;
        }

        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);
            bindable.TextChanged -= this.OnEntryTextChanged;
        }


        private void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            var entry = (Entry)sender;

            if (entry.Text.Length > this.MaxLength)
            {
                entry.TextChanged -= this.OnEntryTextChanged;

                // ignore the entered character
                entry.Text = e.OldTextValue;

                entry.TextChanged += this.OnEntryTextChanged;
            }
        }
    }
}
