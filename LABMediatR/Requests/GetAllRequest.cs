using MediatR;
using System.Collections.Generic;

namespace LABMediatR.Requests
{
    using Domain;

    public class GetAllRequest : IRequest<IEnumerable<Customer>>
    {
    }
}
