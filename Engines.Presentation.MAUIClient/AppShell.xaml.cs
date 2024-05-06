using Engines.Presentation.MAUIClient.Pages;
using Engines.Presentation.MAUIClient.Pages.Common;
using Engines.Presentation.MAUIClient.Pages.Engines;

namespace Engines.Presentation.MAUIClient
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
        }
        public void RegisterRoutes()
        {
            Routing.RegisterRoute(Routes.MainRoute, typeof(MainPage));
            Routing.RegisterRoute(Routes.DiselEnginePageRoute, typeof(Pages.Engines.Disel.DiselEnginePage));
            Routing.RegisterRoute(Routes.ICEEnginePageRoute, typeof(Pages.Engines.ICE.ICEEnginePage));
            Routing.RegisterRoute(Routes.JetEnginePageRoute, typeof(Pages.Engines.Jet.JetEnginePage));
            Routing.RegisterRoute(Routes.EngineRoute, typeof(EnginePage));
        }
    }
}
