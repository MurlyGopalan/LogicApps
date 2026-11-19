using MediatR;

namespace LogicApi.Handlers
{
    public class Complete : IRequestHandler<Requests.Complete,string>
    {
        public Task<string> Handle(Requests.Complete request, CancellationToken cancellationToken)
        {
            return Task.FromResult($"Completed Order: {request.Id}");
        }
    }
}
