using CrudMudBlazor.Services;
using FastEndpoints;

namespace CrudMudBlazor.Endpoints
{
    public class AddPersonEndpoint : Endpoint<AddPersonRequest>
    {
        public readonly IPartyService _partyService;


        public AddPersonEndpoint(IPartyService partyService)
        {
            _partyService = partyService;
        }
        public override void Configure()
        {
            Post("/api/person/add");
            AllowAnonymous();
        }

        public override async Task HandleAsync(AddPersonRequest req, CancellationToken ct)
        {
            await _partyService.AddPerson(req.FirstName, req.LastName, req.DateBirth, req.Name, req.Description);
        }
    }

    public record AddPersonRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateBirth { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
