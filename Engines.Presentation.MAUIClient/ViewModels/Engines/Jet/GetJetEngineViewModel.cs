using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Engines.Application.Common.Interfaces.Services;
using Engines.Presentation.MAUIClient.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engines.Presentation.MAUIClient.ViewModels.Engines.Jet
{
    public partial class GetJetEngineViewModel : BaseViewModel
    {
        private readonly IJetService _jetService;

        public GetJetEngineViewModel(IJetService jetService)
        {
            _jetService = jetService;
        }

        [ObservableProperty]
        List<Domain.Entities.Jet> engineList = new();

        [ObservableProperty]
        private string search;

        public void ReloadList()
        {
            EngineList = _jetService.GetList(Search);
        }

        [RelayCommand]
        public void SearchList()
        {

            ReloadList();
        }
    }
}
