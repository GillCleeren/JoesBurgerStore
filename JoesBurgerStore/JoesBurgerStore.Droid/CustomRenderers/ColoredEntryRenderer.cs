using JoesBurgerStore.CustomRenderers;
using JoesBurgerStore.Droid.CustomRenderers;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer (typeof(ColoredEntry), typeof(ColoredEntryRenderer))]
namespace JoesBurgerStore.Droid.CustomRenderers
{
    class ColoredEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            Control?.SetBackgroundColor(global::Android.Graphics.Color.LightGreen);
        }
    }
}