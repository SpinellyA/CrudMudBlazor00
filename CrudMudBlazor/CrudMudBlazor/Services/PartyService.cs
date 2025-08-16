using CrudMudBlazor.Data;
using CrudMudBlazor.Models;

namespace CrudMudBlazor.Services
{
    public class PartyService : IPartyService
    {
        public readonly PartyDbContext _context;
        public PartyService(PartyDbContext context)
        {
            _context = context;
        }
        public Party GetParty(int id)
        {
            return new();
        }
        public async Task AddPartyType(string name, string description)
        {
            PartyType pType = new PartyType
            {
                Name = name,
                Description = description
            };
            _context.Add(pType);
            await _context.SaveChangesAsync();
        }

        public async Task AddPerson(string lastname, string firstname, DateTime birthDate, string name, string description)
        {
            Person person = new Person
            {
                FirstName = firstname,
                LastName = lastname,
                DateOfBirth = birthDate,
                Name = name,
                Description = description
            };
            _context.Add(person);
            await _context.SaveChangesAsync();
        }

        public async Task AddOrganization(string officialName, DateTime foundingDate, string name, string description)
        {
            Organization org = new Organization
            {
                OfficialName = officialName,
                FoundingDate = foundingDate,
                Name = name,
                Description = description,
            };
            _context.Add(org);
            await _context.SaveChangesAsync();
        }
    }
}
