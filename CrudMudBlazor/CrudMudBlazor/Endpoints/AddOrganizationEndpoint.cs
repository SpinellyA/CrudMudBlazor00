using CrudMudBlazor.Services;
using FastEndpoints;

namespace CrudMudBlazor.Endpoints
{
    public class AddOrganizationEndpoint : Endpoint<AddOrganizationRequest>
    {
        public readonly IPartyService _partyService;


        public AddOrganizationEndpoint(IPartyService partyService)
        {
            _partyService = partyService;
        }
        public override void Configure()
        {
            Post("/api/organization/add");
            AllowAnonymous();
        }

        public override async Task HandleAsync(AddOrganizationRequest req, CancellationToken ct)
        {
            await _partyService.AddOrganization(req.OfficialName, req.DateBirth, req.Name, req.Description);
        }
    }

    public record AddOrganizationRequest
    {
        public string OfficialName { get; set; }
        public DateTime DateBirth { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
