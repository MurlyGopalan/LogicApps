using LogicApi.Entities;
using MediatR;

namespace LogicApi.Requests
{
    public class Create: IRequest<Order>
    {
        public Order? Order { get; set; }
    }
}
