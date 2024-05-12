using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engines.Domain.Entities;
using CommunityToolkit.Mvvm.Input;
using Engines.Application.Common.Interfaces.Services;
using Engines.Presentation.MAUIClient.ViewModels.Base;

namespace Engines.Presentation.MAUIClient.ViewModels.Engines.Jet
{
    public partial class AddJetEngineViewModel : BaseViewModel
    {

        [ObservableProperty]
        private Domain.Entities.Jet engine = new();
        private readonly IJetService _jetService;

        public AddJetEngineViewModel(IJetService jetService) { _jetService = jetService; }

        [RelayCommand]
        public async Task AddJetEngine()
        {
            Guid id = Guid.NewGuid();
            _jetService.Add(new Domain.Entities.Jet()
            {
                Id = id,
                Name = engine.Name,
                FuelType = engine.FuelType,
                Fuel = engine.Fuel,
                Traction = engine.Traction,
                Overclocking = engine.Overclocking,
                Operational_duration = engine.Operational_duration
            });

            await Shell.Current.GoToAsync("..");
        }
    }
}
