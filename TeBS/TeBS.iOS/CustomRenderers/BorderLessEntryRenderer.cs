using System;
using System.ComponentModel;
using TeBS.CustomRenderers;
using TeBS.iOS.CustomRenderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
[assembly:ExportRenderer(typeof(BorderLessEntry),typeof(BorderlessEntryRenderer))]
namespace TeBS.iOS.CustomRenderers
{
    public class BorderlessEntryRenderer : EntryRenderer
    {
        protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            base.OnElementPropertyChanged(sender, e);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);


            Control.Layer.BorderWidth = 0;
            Control.BorderStyle = UITextBorderStyle.None;
            Control.Font = UIFont.SystemFontOfSize(16);
        }
    }
}
