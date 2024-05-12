using Engines.Domain.Entities;

namespace Engines.Application.Common.Interfaces.Repositories
{
    public interface IICERepository
    {
        ICE Add(ICE ice);

        ICE Update(ICE ice);

        void Remove(ICE ice);

        ICE? GetById(Guid Id);

        List<ICE> GetList(string Name);
    }
}