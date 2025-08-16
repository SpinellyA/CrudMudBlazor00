using CrudMudBlazor.Services;
using FastEndpoints;

namespace CrudMudBlazor.Endpoints
{
    public class AddPartyTypeEndpoint : Endpoint<PartyTypeRequest>
    {
        public readonly IPartyService _partyService;


        public AddPartyTypeEndpoint(IPartyService partyService)
        {
            _partyService = partyService;
        }
        public override void Configure()
        {
            Post("/api/ptype/add");
            AllowAnonymous();
        }

        public override async Task HandleAsync(PartyTypeRequest req, CancellationToken ct)
        {
            await _partyService.AddPartyType(req.Name, req.Description);
        }
    }

    public record PartyTypeRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
