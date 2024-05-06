using Engines.Infrastructure;
using Engines.Presentation.MAUIClient.Pages;
using Engines.Presentation.MAUIClient.ViewModels;

namespace Engines.Presentation.MAUIClient
{
    public static class DependencyInjection
    {
        public static MauiAppBuilder RegisterServices(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddInfrastructure();
            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
        {
            mauiAppBuilder.Services.AddSingleton<ViewModels.MainPageViewModel>();
            mauiAppBuilder.Services.AddSingleton<ViewModels.Engines.Disel.DiselEngineViewModel>();
            mauiAppBuilder.Services.AddSingleton<ViewModels.Engines.ICE.ICEEngineViewModel>();
            mauiAppBuilder.Services.AddSingleton<ViewModels.Engines.Jet.JetEngineViewModel>();
            mauiAppBuilder.Services.AddSingleton<ViewModels.Engines.EnginePageViewModel>();

            return mauiAppBuilder;
        }
        public static MauiAppBuilder RegisterPages(this MauiAppBuilder mauiAppBuilder)
        {

            mauiAppBuilder.Services.AddSingleton<Pages.MainPage>();
            mauiAppBuilder.Services.AddSingleton<Pages.Engines.Disel.DiselEnginePage>();
            mauiAppBuilder.Services.AddSingleton<Pages.Engines.ICE.ICEEnginePage>();
            mauiAppBuilder.Services.AddSingleton<Pages.Engines.Jet.JetEnginePage>();
            mauiAppBuilder.Services.AddSingleton<Pages.Engines.EnginePage>();
            return mauiAppBuilder;
        }
    }
}
