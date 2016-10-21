using Autofac;
using JoesBurgerStore.Contracts;
using JoesBurgerStore.Contracts.ViewModels;
using JoesBurgerStore.Services;
using JoesBurgerStore.ViewModels;
using Xamarin.Forms;

namespace JoesBurgerStore
{
    public class Bootstrap
    {
        public IContainer CreateContainer()
        {
            var containerBuilder = new ContainerBuilder();
            RegisterDependencies(containerBuilder);
            return containerBuilder.Build();
        }

        protected virtual void RegisterDependencies(ContainerBuilder builder)
        {
            // Register Services
            builder.RegisterType<BurgerDataService>()
                .As<IBurgerDataService>()
                .SingleInstance();

            builder.RegisterType<UserDataService>()
                .As<IUserDataService>()
                .SingleInstance();

            builder.RegisterType<NavigationService>()
                .As<INavigationService>()
                .SingleInstance();

            builder.RegisterType<CameraService>()
                .As<ICameraService>()
                .SingleInstance();

            builder.RegisterType<CartDataService>()
                .As<ICartDataService>()
                .SingleInstance();

            builder.RegisterType<AboutViewModel>()
                .As<IAboutViewModel>()
                .SingleInstance();

            builder.RegisterType<BurgerDetailViewModel>()
                .As<IBurgerDetailViewModel>()
                .SingleInstance();

            //builder.RegisterType<CartViewModel>();

            builder.RegisterType<CartViewModel>()
                .As<ICartViewModel>()
                .SingleInstance();

            //builder.RegisterType<LoginViewModel>();

            builder.RegisterType<LoginViewModel>()
                .As<ILoginViewModel>()
                .SingleInstance();

            //builder.RegisterType<MenuViewModel>();

            builder.RegisterType<MenuViewModel>()
                .As<IMenuViewModel>()
                .SingleInstance();

            //builder.RegisterType<OrderBurgersViewModel>();

            builder.RegisterType<OrderBurgersViewModel>()
                .As<IOrderBurgersViewModel>()
                .SingleInstance();

            //builder.RegisterType<ShowMapViewModel>();

            builder.RegisterType<ShowMapViewModel>()
                .As<IShowMapViewModel>()
                .SingleInstance();

            //builder.RegisterType<TakePictureViewModel>();

            builder.RegisterType<TakePictureViewModel>()
                .As<ITakePictureViewModel>()
                .SingleInstance();
        }
    }
}
