using Engines.Presentation.MAUIClient.ViewModels.Engines.Jet;

namespace Engines.Presentation.MAUIClient.Pages.Engines.Jet;

public partial class GetJetEnginePage : ContentPage
{
    private readonly GetJetEngineViewModel _getJetEngineViewModel;
    public GetJetEnginePage(GetJetEngineViewModel getJetEngineViewModel)
    {
        InitializeComponent();

        BindingContext = _getJetEngineViewModel = getJetEngineViewModel;
    }
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _getJetEngineViewModel.ReloadList();
    }
}