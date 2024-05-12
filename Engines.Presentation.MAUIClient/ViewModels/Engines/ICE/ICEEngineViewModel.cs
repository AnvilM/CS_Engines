using CommunityToolkit.Mvvm.Input;
using Engines.Presentation.MAUIClient.Pages.Common;
using Engines.Presentation.MAUIClient.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engines.Presentation.MAUIClient.ViewModels.Engines.ICE
{
    public partial class ICEEngineViewModel : BaseViewModel
    {
        [RelayCommand]
        public async void GoToAddICEEnginePage()
        {

            await Shell.Current.GoToAsync(Routes.AddICEEnginePageRoute);
        }


        [RelayCommand]
        public async void GoToGetICEEnginePage()
        {

            await Shell.Current.GoToAsync(Routes.GetICEEnginePageRoute);
        }
    }
}
