using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Engines.Application.Common.Interfaces.Services;
using Engines.Presentation.MAUIClient.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engines.Presentation.MAUIClient.ViewModels.Engines.Disel
{
    public partial class GetDiselEngineViewModel : BaseViewModel
    {
        private readonly IDiselService _diselService;

        public GetDiselEngineViewModel(IDiselService diselService)
        {
            _diselService = diselService;
        }

        [ObservableProperty]
        List<Domain.Entities.Disel> engineList = new();

        [ObservableProperty]
        private string search;

        public void ReloadList()
        {
            EngineList = _diselService.GetList(Search);
        }

        [RelayCommand]
        public void SearchList()
        {

            ReloadList();
        }
    }
}
