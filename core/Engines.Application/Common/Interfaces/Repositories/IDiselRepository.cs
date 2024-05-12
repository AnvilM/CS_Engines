using Engines.Domain.Entities;

namespace Engines.Application.Common.Interfaces.Repositories
{
    public interface IDiselRepository
    {
        Disel Add(Disel disel);

        Disel Update(Disel disel);

        void Remove(Disel disel);

        Disel? GetById(Guid Id);

        List<Disel> GetList(string Name);
    }
}