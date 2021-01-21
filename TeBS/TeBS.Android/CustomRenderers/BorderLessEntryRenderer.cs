using System;
using Android.Content;
using TeBS.CustomRenderers;
using TeBS.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
[assembly: ExportRenderer(typeof(BorderLessEntry), typeof(BorderLessEntryRenderer))]

namespace TeBS.Droid.CustomRenderers
{
    public class BorderLessEntryRenderer : EntryRenderer
    {
        public BorderLessEntryRenderer(Context context) : base(context)
        {
        }


        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement == null)
            {
                Control.Background = null;
            }

            Control.TextSize = 16;
        }

    }
}
