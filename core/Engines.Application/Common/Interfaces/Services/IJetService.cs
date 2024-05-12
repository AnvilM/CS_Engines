using Engines.Domain.Entities;

namespace Engines.Application.Common.Interfaces.Services
{
    public interface IJetService
    {
        Jet Add(Jet jet);

        Jet Update(Jet jet);

        void Remove(Jet jet);

        Jet? GetById(Guid Id);

        List<Jet> GetList(string Name);
    }
}