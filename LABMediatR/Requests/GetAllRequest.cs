using MediatR;
using System.Collections.Generic;

namespace LABMediatR.Requests
{
    using Models;

    public class GetAllRequest : IRequest<IEnumerable<Customer>>
    {
    }
}
