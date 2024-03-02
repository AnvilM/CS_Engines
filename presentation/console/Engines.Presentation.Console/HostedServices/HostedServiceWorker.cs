using Microsoft.Extensions.Hosting;
using Engines.Application.Common.Interfaces.Services;
using System;

namespace Engines.Presentation.Console.HostedServices
{
    public class HostedServiceWorker : IHostedService
    {

        private readonly IDiselService _diselService;

        public HostedServiceWorker(IDiselService diselService){
            _diselService = diselService;
        }
        
        public async Task StartAsync(CancellationToken cancellationToken){
            await Task.Delay(1);
            BuildMenu();
        }

        private void BuildMenu(){
            System.Console.WriteLine("Выберите пункт меню для начала:");
            System.Console.WriteLine("1 - Добавить объект");
            System.Console.WriteLine("2 - Получить объект");
            var key = System.Console.ReadKey();
            System.Console.Clear();
            switch (key.KeyChar)
            {
                case '1':
                    var newRect = new Domain.Entities.Disel()
                    {
                        Volume = 100,
                        Id = Guid.NewGuid(),
                        Name = $"Прямоугольник от {DateTime.Now.ToString()}"
                    };
                    System.Console.WriteLine($"Создан прямоугольник Id: {newRect.Id}, Name= {newRect.Name}");
                    _diselService.Add(newRect);
                    break;
                case '2':
                    break;
                default:
                    break;
            }
        }

        public async Task StopAsync(CancellationToken cancellationToken){
            await Task.Delay(1);
        }


        


    }
}
