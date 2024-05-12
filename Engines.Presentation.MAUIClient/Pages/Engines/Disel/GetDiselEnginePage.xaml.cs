using Engines.Presentation.MAUIClient.ViewModels.Engines.Disel;

namespace Engines.Presentation.MAUIClient.Pages.Engines.Disel;

public partial class GetDiselEnginePage : ContentPage
{
	private readonly GetDiselEngineViewModel _getDiselEngineViewModel;
	public GetDiselEnginePage(GetDiselEngineViewModel getDiselEngineViewModel)
	{
		InitializeComponent();

		BindingContext = _getDiselEngineViewModel = getDiselEngineViewModel;
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        _getDiselEngineViewModel.ReloadList();
    }
}