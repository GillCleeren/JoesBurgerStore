using System;
using System.Collections.Generic;
using System.Text;
using JoesBurgerStore.CustomRenderers;
using JoesBurgerStore.iOS.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(RoundButton), typeof(RoundButtonRenderer))]
namespace JoesBurgerStore.iOS.CustomRenderers
{
    public class RoundButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                var button = (RoundButton)e.NewElement;

                button.SizeChanged += (s, args) =>
                {
                    var radius = Math.Min(button.Width, button.Height) / 2.0;
                    button.BorderRadius = (int)(radius);
                };
            }
        }
    }
}
