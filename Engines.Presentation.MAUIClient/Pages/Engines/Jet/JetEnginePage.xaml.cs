using Engines.Presentation.MAUIClient.ViewModels.Engines.Jet;

namespace Engines.Presentation.MAUIClient.Pages.Engines.Jet;

public partial class JetEnginePage : ContentPage
{
	private readonly JetEngineViewModel _jetEngineViewModel;
	public JetEnginePage(JetEngineViewModel jetEngineViewModel)
	{
		InitializeComponent();

		BindingContext = _jetEngineViewModel = jetEngineViewModel;
	}
}