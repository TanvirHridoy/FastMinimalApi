using FastEndpoints;

namespace FastMinimalApi.Endpoints
{
    public class ExampleEndpoints : EndpointWithoutRequest
    {
        public override void Configure()
        {
            Verbs(Http.GET);
            Routes("api/example");
            AllowAnonymous();


                
        }

        public override async  Task HandleAsync(CancellationToken ct)
        {
            await SendAsync(new {name="Ani",Age=420},cancellation: ct);
        }
    }
}
