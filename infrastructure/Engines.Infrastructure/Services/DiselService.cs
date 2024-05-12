using Engines.Domain.Entities;
using Engines.Application.Common.Interfaces.Repositories;
using Engines.Application.Common.Interfaces.Services;

namespace Engines.Infrastructure.Services
{
    public class DiselService : IDiselService
    {
        private readonly IDiselRepository _diselRepository;

        public DiselService(IDiselRepository diselRepository){
            _diselRepository = diselRepository;
        }


        public Disel Add(Disel disel){
            if(disel.Volume < 0){
                throw new Exception("Объём не может иметь отрицательное значение");
            }

            if(disel.Fuel < 0) 
            {
                throw new Exception("Топливо не может иметь отрицательное значение");
            }

            if (disel.Power < 0)
            {
                throw new Exception("Мощность не может иметь отрицательное значение");
            }

            if (disel.RPM < 0)
            {
                throw new Exception("Обороты в минуту не может иметь отрицательное значение");
            }

            return _diselRepository.Add(disel);
        }

        public Disel? GetById(Guid Id){
            return _diselRepository.GetById(Id);
        }

        public void Remove(Disel disel){
            _diselRepository.Remove(disel);
        }

        public Disel Update(Disel disel){
            return _diselRepository.Update(disel);
        }

        public List<Disel> GetList(string Name) 
        {
            return _diselRepository.GetList(Name);
        }
    }
}