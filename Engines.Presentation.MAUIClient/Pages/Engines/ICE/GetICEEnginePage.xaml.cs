using Engines.Presentation.MAUIClient.ViewModels.Engines.ICE;

namespace Engines.Presentation.MAUIClient.Pages.Engines.ICE;

public partial class GetICEEnginePage : ContentPage
{
    private readonly GetICEEngineViewModel _getICEEngineViewModel;
    public GetICEEnginePage(GetICEEngineViewModel getICEEngineViewModel)
    {
        InitializeComponent();

        BindingContext = _getICEEngineViewModel = getICEEngineViewModel;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _getICEEngineViewModel.ReloadList();
    }
}