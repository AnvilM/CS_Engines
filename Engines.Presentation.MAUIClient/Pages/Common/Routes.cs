using Engines.Presentation.MAUIClient.Pages.Engines;
using Engines.Presentation.MAUIClient.Pages.Engines.Disel;
using Engines.Presentation.MAUIClient.Pages.Engines.ICE;
using Engines.Presentation.MAUIClient.Pages.Engines.Jet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engines.Presentation.MAUIClient.Pages.Common
{
    public static class Routes
    {
        public static string MainRoute { get; } = nameof(MainPage);

        public static string DiselEnginePageRoute { get; } = nameof(DiselEnginePage);
        public static string ICEEnginePageRoute { get; } = nameof(ICEEnginePage);
        public static string JetEnginePageRoute { get; } = nameof(JetEnginePage);

        public static string AddDiselEnginePageRoute { get; } = nameof(AddDiselEnginePage);
        public static string AddICEEnginePageRoute { get; } = nameof(AddICEEnginePage);
        public static string AddJetEnginePageRoute { get; } = nameof(AddJetEnginePage);

        public static string GetDiselEnginePageRoute { get; } = nameof(GetDiselEnginePage);
        public static string GetICEEnginePageRoute { get; } = nameof(GetICEEnginePage);
        public static string GetJetEnginePageRoute { get; } = nameof(GetJetEnginePage);

        public static string EngineRoute { get; } = nameof(EnginePage);
    }
}
