using System.Threading.Tasks;
using MediatR;
using System.Collections.Generic;

namespace LABMediatR.Handlers
{
    using Domain;
    using Requests;
    using Repository;
    using System.Threading;

    public class CustomerHandler : IRequestHandler<GetAllRequest, IEnumerable<Customer>>
    {
        private ICustomerRepository _customerRepository { get; }
        
        public CustomerHandler(ICustomerRepository customerRepository) =>
            _customerRepository = customerRepository;

        /// <summary>
        /// Processa a requisição assinada pelo request
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Customer>> Handle(GetAllRequest request, CancellationToken cancellationToken) =>
            await _customerRepository.GetAll().ConfigureAwait(false);



    }
}
