using Engines.Application.Common.Interfaces.Repositories;
using Engines.Domain.Entities;
using System.Xml.Linq;

namespace Engines.Infrastructure.Persistence.Repositories
{
    public class DiselRepository : IDiselRepository
    {
        private static List<Disel> _diselList = new List<Disel>();

        public Disel Add(Disel disel){
            _diselList.Add(disel);
            return disel;
        }

        public Disel? GetById(Guid Id){
            return _diselList.Where(m => m.Id == Id).FirstOrDefault();
        }

        public void Remove(Disel disel){
            _diselList.Remove(disel);
        }

        public Disel Update(Disel disel){
            var index = _diselList.IndexOf(disel);
            if(index >= 0){
                return _diselList[index] = disel;
            }
            return disel;
        }

        public List<Disel> GetList(string Name)
        {
            return _diselList.
                Where(engine => engine.
            Name.ToLower().StartsWith((Name ?? "").ToLower())).ToList();
        }
    }
}