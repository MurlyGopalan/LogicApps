using MediatR;

namespace LogicApi.Handlers
{
    public class Get: IRequestHandler<Requests.Get, IEnumerable<string>>
    {
        public Task<IEnumerable<string>> Handle(Requests.Get request, CancellationToken cancellationToken)
        {
            if (string.IsNullOrEmpty(request.Id))
            {
                return Task.FromResult<IEnumerable<string>>(new List<string> { "Order1", "Order2", "Order3" });
            }
            else
            {
                return Task.FromResult<IEnumerable<string>>(new List<string> { $"Order: {request.Id}" });
            }
        }
    }
    
}
