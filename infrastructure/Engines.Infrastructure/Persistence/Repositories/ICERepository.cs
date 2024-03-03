using Engines.Application.Common.Interfaces.Repositories;
using Engines.Domain.Entities;

namespace Engines.Infrastructure.Persistence.Repositories
{
    public class ICERepository : IICERepository
    {
        private static List<ICE> _iceList = new List<ICE>();

        public ICE Add(ICE ice){
            _iceList.Add(ice);
            return ice;
        }

        public ICE? GetById(Guid Id){
            return _iceList.Where(m => m.Id == Id).FirstOrDefault();
        }

        public void Remove(ICE ice){
            _iceList.Remove(ice);
        }

        public ICE Update(ICE ice){
            var index = _iceList.IndexOf(ice);
            if(index >= 0){
                return _iceList[index] = ice;
            }
            return ice;
        }
    }
}