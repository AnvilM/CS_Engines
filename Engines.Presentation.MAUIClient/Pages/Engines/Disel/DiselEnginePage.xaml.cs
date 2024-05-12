using Engines.Presentation.MAUIClient.ViewModels.Engines;
using Engines.Presentation.MAUIClient.ViewModels.Engines.Disel;

namespace Engines.Presentation.MAUIClient.Pages.Engines.Disel;

public partial class DiselEnginePage : ContentPage
{
    private readonly DiselEngineViewModel _diselEngineViewModel;
	public DiselEnginePage(DiselEngineViewModel diselEngineViewModel)
	{
		InitializeComponent();

        BindingContext = _diselEngineViewModel = diselEngineViewModel;
	}
}

