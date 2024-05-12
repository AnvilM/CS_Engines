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

namespace Engines.Presentation.MAUIClient.ViewModels.Engines.Disel
{
    public partial class AddDiselEngineViewModel : BaseViewModel
    {
       
        [ObservableProperty]
        private Domain.Entities.Disel engine = new();
        private readonly IDiselService _diselService;

        public AddDiselEngineViewModel(IDiselService diselService) { _diselService = diselService; }

        [RelayCommand]
        public async Task AddDiselEngine()
        {
            Guid id = Guid.NewGuid();
            _diselService.Add(new Domain.Entities.Disel()
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
