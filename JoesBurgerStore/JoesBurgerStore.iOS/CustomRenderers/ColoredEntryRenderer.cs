using System;
using System.Collections.Generic;
using System.Text;
using JoesBurgerStore.CustomRenderers;
using JoesBurgerStore.iOS.CustomRenderers;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer (typeof(ColoredEntry), typeof(ColoredEntryRenderer))]
namespace JoesBurgerStore.iOS.CustomRenderers
{
    public class ColoredEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                // do whatever you want to the UITextField here!
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
}
