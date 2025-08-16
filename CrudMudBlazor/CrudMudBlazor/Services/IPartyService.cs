using CrudMudBlazor.Models;

namespace CrudMudBlazor.Services
{
    public interface IPartyService
    {
        Party GetParty(int id);
        Task AddPartyType(string name, string description);
        Task AddPerson(string lastname, string firstname, DateTime birthDate, string name, string description);
        Task AddOrganization(string officialName, DateTime foundingDate, string name, string description);
    }
}
