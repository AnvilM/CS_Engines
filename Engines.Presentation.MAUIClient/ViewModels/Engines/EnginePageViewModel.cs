using Engines.Presentation.MAUIClient.ViewModels.Base;
using Engines.Application.Common.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engines.Presentation.MAUIClient.Pages.Common;
using CommunityToolkit.Mvvm.Input;

namespace Engines.Presentation.MAUIClient.ViewModels.Engines
{
    public partial class EnginePageViewModel : BaseViewModel
    {
        [RelayCommand]
        public async void GoToDiselEnginePage()
        {

            await Shell.Current.GoToAsync(Routes.DiselEnginePageRoute);
        }

        [RelayCommand]
        public async void GoToICEEnginePage()
        {

            await Shell.Current.GoToAsync(Routes.ICEEnginePageRoute);
        }

        [RelayCommand]
        public async void GoToJetEnginePage()
        {

            await Shell.Current.GoToAsync(Routes.JetEnginePageRoute);
        }

    }
}
