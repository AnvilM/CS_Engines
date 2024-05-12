using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using Engines.Presentation.MAUIClient.Pages.Common;
using Engines.Presentation.MAUIClient.ViewModels.Base;

namespace Engines.Presentation.MAUIClient.ViewModels.Engines.Jet
{
    public partial class JetEngineViewModel : BaseViewModel
    {
        [RelayCommand]
        public async void GoToAddJetEnginePage()
        {

            await Shell.Current.GoToAsync(Routes.AddJetEnginePageRoute);
        }


        [RelayCommand]
        public async void GoToGetJetEnginePage()
        {

            await Shell.Current.GoToAsync(Routes.GetJetEnginePageRoute);
        }
    }
}
