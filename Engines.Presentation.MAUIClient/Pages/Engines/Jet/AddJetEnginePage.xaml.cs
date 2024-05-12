using Engines.Presentation.MAUIClient.ViewModels.Engines.Jet;

namespace Engines.Presentation.MAUIClient.Pages.Engines.Jet;

public partial class AddJetEnginePage : ContentPage
{
    private readonly AddJetEngineViewModel _addJetEngineViewModel;
    public AddJetEnginePage(AddJetEngineViewModel addJetEngineViewModel)
    {
        InitializeComponent();

        BindingContext = _addJetEngineViewModel = addJetEngineViewModel;
    }
}