using Engines.Domain.Entities;

namespace Engines.Application.Common.Interfaces.Services
{
    public interface IDiselService
    {
        Disel Add(Disel disel);

        Disel Update(Disel disel);

        void Remove(Disel disel);

        Disel? GetById(Guid Id);

        List<Disel> GetList(string Name);
    }
}