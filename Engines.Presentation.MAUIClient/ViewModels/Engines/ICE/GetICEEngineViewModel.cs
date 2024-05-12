using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Engines.Application.Common.Interfaces.Services;
using Engines.Presentation.MAUIClient.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engines.Presentation.MAUIClient.ViewModels.Engines.ICE
{
    public partial class GetICEEngineViewModel : BaseViewModel
    {
        private readonly IICEService _iceService;

        public GetICEEngineViewModel(IICEService iceService)
        {
            _iceService = iceService;
        }

        [ObservableProperty]
        List<Domain.Entities.ICE> engineList = new();

        [ObservableProperty]
        private string search;

        public void ReloadList()
        {
            EngineList = _iceService.GetList(Search);
        }

        [RelayCommand]
        public void SearchList()
        {

            ReloadList();
        }
    }
}
