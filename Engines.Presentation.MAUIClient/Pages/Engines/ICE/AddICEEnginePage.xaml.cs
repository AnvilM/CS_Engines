using Engines.Presentation.MAUIClient.ViewModels.Engines.ICE;

namespace Engines.Presentation.MAUIClient.Pages.Engines.ICE;

public partial class AddICEEnginePage : ContentPage
{
    private readonly AddICEEngineViewModel _addICEEngineViewModel;
    public AddICEEnginePage(AddICEEngineViewModel addICEEngineViewModel)
    {
        InitializeComponent();

        BindingContext = _addICEEngineViewModel = addICEEngineViewModel;
    }
}