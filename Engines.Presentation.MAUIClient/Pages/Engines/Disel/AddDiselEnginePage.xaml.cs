using Engines.Presentation.MAUIClient.ViewModels.Engines.Disel;

namespace Engines.Presentation.MAUIClient.Pages.Engines.Disel;

public partial class AddDiselEnginePage : ContentPage
{
	private readonly AddDiselEngineViewModel _addDiselEngineViewModel;
	public AddDiselEnginePage(AddDiselEngineViewModel addDiselEngineViewModel)
	{
		InitializeComponent();

		BindingContext = _addDiselEngineViewModel = addDiselEngineViewModel;
	}
}