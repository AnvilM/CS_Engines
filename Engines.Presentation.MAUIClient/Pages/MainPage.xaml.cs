using Engines.Presentation.MAUIClient.ViewModels;

namespace Engines.Presentation.MAUIClient.Pages
{
    public partial class MainPage : ContentPage
    {
        private readonly MainPageViewModel _mainPageViewModel;
        public MainPage(MainPageViewModel mainPageViewModel)
        {
            InitializeComponent();
            BindingContext = _mainPageViewModel = mainPageViewModel;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {

        }
    }

}