using LogicApi.Entities;
using MediatR;

namespace LogicApi.Handlers
{
    public class Create : IRequestHandler<Requests.Create,Order>
    {
        public Task<Order> Handle(Requests.Create request, CancellationToken cancellationToken)
        {
            return Task.FromResult(request.Order ?? new Order());
        }
    }
}
