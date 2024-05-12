using Engines.Presentation.MAUIClient.ViewModels.Engines.ICE;

namespace Engines.Presentation.MAUIClient.Pages.Engines.ICE;

public partial class ICEEnginePage : ContentPage
{
	private readonly ICEEngineViewModel _iCEEngineViewModel;
	public ICEEnginePage(ICEEngineViewModel iCEEngineViewModel)
	{
		InitializeComponent();

		BindingContext = _iCEEngineViewModel = iCEEngineViewModel;
	}
}
