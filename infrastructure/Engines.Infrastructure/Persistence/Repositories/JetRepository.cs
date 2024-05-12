using Engines.Application.Common.Interfaces.Repositories;
using Engines.Domain.Entities;

namespace Engines.Infrastructure.Persistence.Repositories
{
    public class JetRepository : IJetRepository
    {
        private static List<Jet> _JetList = new List<Jet>();

        public Jet Add(Jet jet){
            _JetList.Add(jet);
            return jet;
        }

        public Jet? GetById(Guid Id){
            return _JetList.Where(m => m.Id == Id).FirstOrDefault();
        }

        public void Remove(Jet jet)
        {
            _JetList.Remove(jet);
        }

        public Jet Update(Jet jet)
        {
            var index = _JetList.IndexOf(jet);
            if(index >= 0){
                return _JetList[index] = jet;
            }
            return jet;
        }

        public List<Jet> GetList(string Name)
        {
            return _JetList.
                Where(engine => engine.
            Name.ToLower().StartsWith((Name ?? "").ToLower())).ToList();
        }
    }
}