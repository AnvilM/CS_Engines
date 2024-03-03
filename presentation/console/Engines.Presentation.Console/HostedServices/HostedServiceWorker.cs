using Microsoft.Extensions.Hosting;
using Engines.Application.Common.Interfaces.Services;
using System;

namespace Engines.Presentation.Console.HostedServices
{
    public class HostedServiceWorker : IHostedService
    {

        private readonly IDiselService _diselService;
        private readonly IJetService _jetService;
        private readonly IICEService _iceService;

        public HostedServiceWorker(IDiselService diselService, IJetService jetService, IICEService iceService){
            _diselService = diselService;
            _jetService = jetService;
            _iceService = iceService;
        }
        
        public async Task StartAsync(CancellationToken cancellationToken){
            await Task.Delay(1);
            BuildMenu();
        }

        private void BuildMenu(){

            UI.Welcome();

            var key = System.Console.ReadKey();
            System.Console.Clear();

            switch (key.KeyChar)
            {
                case '1':

                    UI.Add();

                    key = System.Console.ReadKey();
                    System.Console.Clear();

                    string[] engine = UI.Engine();

                    if (key.KeyChar == '1')
                    {
                        int[] ice = UI.ICE();

                        var newICE = new Domain.Entities.ICE()
                        {
                            Id = Guid.NewGuid(),
                            Name = $"Двигатель от {DateTime.Now.ToString()}",
                            FuelType = engine[0],
                            Fuel = Convert.ToInt32(engine[1]),
                            Volume = ice[0],
                            Power = ice[1],
                            RPM = ice[2]

                        };

                        System.Console.WriteLine($"Создан двигатель Id: {newICE.Id}");
                        _iceService.Add(newICE);

                    }
                    else if (key.KeyChar == '2')
                    {
                        int[] disel = UI.Disel();

                        var newDisel = new Domain.Entities.Disel()
                        {
                            Id = Guid.NewGuid(),
                            Name = $"Двигатель от {DateTime.Now.ToString()}",
                            FuelType = engine[0],
                            Fuel = Convert.ToInt32(engine[1]),
                            Volume = disel[0],
                            Power = disel[1],
                            RPM = disel[2]

                        };

                        System.Console.WriteLine($"Создан двигатель Id: {newDisel.Id}");
                        _diselService.Add(newDisel);
                    }

                    else if (key.KeyChar == '3')
                    {
                        int[] jet = UI.Jet();

                        var newJet = new Domain.Entities.Jet()
                        {
                            Id = Guid.NewGuid(),
                            Name = $"Двигатель от {DateTime.Now.ToString()}",
                            FuelType = engine[0],
                            Fuel = Convert.ToInt32(engine[1]),
                            Traction = jet[0],
                            Overclocking = jet[1],
                            Operational_duration = jet[2]

                        };

                        System.Console.WriteLine($"Создан двигатель Id: {newJet.Id}");
                        _jetService.Add(newJet);
                    }

                    break;
                case '2':
                    UI.Add();

                    key = System.Console.ReadKey();
                    System.Console.Clear();

                    System.Console.WriteLine("Введите Id двигателя: ");
                    Guid id = Guid.Parse(System.Console.ReadLine());
                    System.Console.Clear();

                    if (key.KeyChar == '1')
                    {
                        

                        System.Console.WriteLine("Id: " + _iceService.GetById(id).Id);
                        System.Console.WriteLine("Название: " + _iceService.GetById(id).Name);
                        System.Console.WriteLine("Тип топлива: " + _iceService.GetById(id).FuelType);
                        System.Console.WriteLine("Топливо: " + _iceService.GetById(id).Fuel);
                        System.Console.WriteLine("Объем: " + _iceService.GetById(id).Volume);
                        System.Console.WriteLine("Мощность: " + _iceService.GetById(id).Power);
                        System.Console.WriteLine("Обороты в минуту: " + _iceService.GetById(id).RPM);
                    }

                    else if(key.KeyChar == '2')
                    {

                        System.Console.WriteLine("Id: " + _diselService.GetById(id).Id);
                        System.Console.WriteLine("Название: " + _diselService.GetById(id).Name);
                        System.Console.WriteLine("Тип топлива: " + _diselService.GetById(id).FuelType);
                        System.Console.WriteLine("Топливо: " + _diselService.GetById(id).Fuel);
                        System.Console.WriteLine("Объем: " + _diselService.GetById(id).Volume);
                        System.Console.WriteLine("Мощность: " + _diselService.GetById(id).Power);
                        System.Console.WriteLine("Обороты в минуту: " + _diselService.GetById(id).RPM);
                    }

                    else if(key.KeyChar == '3')
                    {

                        System.Console.WriteLine("Id: " + _jetService.GetById(id).Id);
                        System.Console.WriteLine("Название: " + _jetService.GetById(id).Name);
                        System.Console.WriteLine("Тип топлива: " + _jetService.GetById(id).FuelType);
                        System.Console.WriteLine("Топливо: " + _jetService.GetById(id).Fuel);
                        System.Console.WriteLine("Тяга: " + _jetService.GetById(id).Traction);
                        System.Console.WriteLine("Разгон: " + _jetService.GetById(id).Overclocking);
                        System.Console.WriteLine("Эксплуатационная продолжительность: " + _jetService.GetById(id).Operational_duration);
                    }

                    System.Console.ReadKey();
                    break;
                default:
                    break;
            }

            BuildMenu();
        }

        public async Task StopAsync(CancellationToken cancellationToken){
            await Task.Delay(1);
        }


        


    }
}
