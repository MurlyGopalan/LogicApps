using MediatR;

namespace LogicApi.Requests
{
    public class Get: IRequest<IEnumerable<string>>
    {
        public string? Id { get; set; }
    }
}
