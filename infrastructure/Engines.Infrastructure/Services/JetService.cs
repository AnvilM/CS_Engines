using Engines.Domain.Entities;
using Engines.Application.Common.Interfaces.Repositories;
using Engines.Application.Common.Interfaces.Services;
using System.Collections.Generic;
using Engines.Infrastructure.Persistence.Repositories;

namespace Engines.Infrastructure.Services
{
    public class JetService : IJetService

    {
        private readonly IJetRepository _jetRepository;

        public JetService(IJetRepository jetRepository){
            _jetRepository = jetRepository;
        }


        public Jet Add(Jet jet){
            if (jet.Traction < 0)
            {
                throw new Exception("Тяга не может иметь отрицательное значение");
            }

            if (jet.Fuel < 0)
            {
                throw new Exception("Топливо не может иметь отрицательное значение");
            }

            if (jet.Overclocking < 0)
            {
                throw new Exception("Разгон не может иметь отрицательное значение");
            }

            if (jet.Operational_duration < 0)
            {
                throw new Exception("Эксплуатационная продолжительность в минуту не может иметь отрицательное значение");
            }

            return _jetRepository.Add(jet);
        }

        public Jet? GetById(Guid Id){
            return _jetRepository.GetById(Id);
        }

        public void Remove(Jet jet){
            _jetRepository.Remove(jet);
        }

        public Jet Update(Jet jet){
            return _jetRepository.Update(jet);
        }

        public List<Jet> GetList(string Name)
        {
            return _jetRepository.GetList(Name);
        }
    }
}