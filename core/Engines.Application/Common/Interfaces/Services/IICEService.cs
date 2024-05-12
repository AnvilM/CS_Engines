using Engines.Domain.Entities;

namespace Engines.Application.Common.Interfaces.Services
{
    public interface IICEService
    {
        ICE Add(ICE ice);

        ICE Update(ICE ice);

        void Remove(ICE ice);

        ICE? GetById(Guid Id);

        List<ICE> GetList(string Name);
    }
}