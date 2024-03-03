using Engines.Domain.Entities;
using Engines.Application.Common.Interfaces.Repositories;
using Engines.Application.Common.Interfaces.Services;

namespace Engines.Infrastructure.Services
{
    public class ICEService : IICEService
    {
        private readonly IICERepository _iceRepository;

        public ICEService(IICERepository iceRepository){
            _iceRepository = iceRepository;
        }


        public ICE Add(ICE ice){
            if (ice.Volume < 0)
            {
                throw new Exception("Объём не может иметь отрицательное значение");
            }

            if (ice.Fuel < 0)
            {
                throw new Exception("Топливо не может иметь отрицательное значение");
            }

            if (ice.Power < 0)
            {
                throw new Exception("Мощность не может иметь отрицательное значение");
            }

            if (ice.RPM < 0)
            {
                throw new Exception("Обороты в минуту не может иметь отрицательное значение");
            }

            return _iceRepository.Add(ice);
        }

        public ICE? GetById(Guid Id){
            return _iceRepository.GetById(Id);
        }

        public void Remove(ICE ice){
            _iceRepository.Remove(ice);
        }

        public ICE Update(ICE ice){
            return _iceRepository.Update(ice);
        }
    }
}