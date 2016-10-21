using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using XLabs.Ioc;
using XLabs.Platform.Device;
using XLabs.Platform.Mvvm;
using XLabs.Platform.Services.Media;
using XLabs.Serialization;

namespace JoesBurgerStore.Droid
{
    [Activity(Label = "JoesBurgerStore", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            var resolverContainer = new SimpleContainer();

            resolverContainer
                .Register<IDevice>(t => AndroidDevice.CurrentDevice)
                .Register<IMediaPicker, MediaPicker>();

            Resolver.SetResolver(resolverContainer.GetResolver());

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

