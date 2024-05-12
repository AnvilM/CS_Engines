using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engines.Presentation.MAUIClient.Pages.Common;
using CommunityToolkit.Mvvm.Input;
using Engines.Presentation.MAUIClient.ViewModels.Base;

namespace Engines.Presentation.MAUIClient.ViewModels.Engines.Disel
{
    public partial class DiselEngineViewModel : BaseViewModel
    {
        [RelayCommand]
        public async void GoToAddDiselEnginePage()
        {

            await Shell.Current.GoToAsync(Routes.AddDiselEnginePageRoute);
        }


        [RelayCommand]
        public async void GoToGetDiselEnginePage()
        {

            await Shell.Current.GoToAsync(Routes.GetDiselEnginePageRoute);
        }
    }
}
