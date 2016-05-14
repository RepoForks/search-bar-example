using System;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms;
using UIKit;
using SearchBarExample.iOS; 

[assembly:ExportRenderer(typeof(Entry), typeof(BorderlessEntryRenderer))]
namespace SearchBarExample.iOS
{
    public class BorderlessEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);

            if (this.Control == null)
                return;

            this.Control.BorderStyle = UITextBorderStyle.None;
        }
    }
}

