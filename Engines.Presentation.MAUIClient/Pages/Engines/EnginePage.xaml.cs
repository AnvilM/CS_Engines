using Engines.Presentation.MAUIClient.ViewModels.Engines;

namespace Engines.Presentation.MAUIClient.Pages.Engines;

public partial class EnginePage : ContentPage
{
    private readonly EnginePageViewModel _enginePageViewModel;
    public EnginePage(EnginePageViewModel enginePageViewModel)
	{
		InitializeComponent();

		BindingContext = _enginePageViewModel = enginePageViewModel;
	}
}