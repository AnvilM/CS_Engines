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

namespace Engines.Presentation.MAUIClient.ViewModels.Engines.ICE
{
    public partial class AddICEEngineViewModel : BaseViewModel
    {

        [ObservableProperty]
        private Domain.Entities.ICE engine = new();
        private readonly IICEService _iceService;

        public AddICEEngineViewModel(IICEService iceService) { _iceService = iceService; }

        [RelayCommand]
        public async Task AddICEEngine()
        {
            Guid id = Guid.NewGuid();
            _iceService.Add(new Domain.Entities.ICE()
            {
                Id = id,
                Name = engine.Name,
                FuelType = engine.FuelType,
                Fuel = engine.Fuel,
                Volume = engine.Volume,
                Power = engine.Power,
                RPM = engine.RPM
            });

            await Shell.Current.GoToAsync("..");
        }
    }
}
