using MediatR;

namespace LogicApi.Requests
{
    public class Complete: IRequest<string>
    {
        public string? Id { get; set; }
    }
}
