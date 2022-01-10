using System.Threading.Tasks;
using MediatR;
using System.Collections.Generic;

namespace LABMediatR.Handlers
{
    using Domain;
    using Requests;
    using Repository;
    using System.Threading;
    using FluentValidation.Results;
    using LABMediatR.Notifications;

    public class CustomerHandler : IRequestHandler<InsertCustomerRequest, ValidationResult>,
                                   IRequestHandler<GetAllRequest, IEnumerable<Customer>>
    {
        private readonly IMediator _mediator;
        private ICustomerRepository _customerRepository { get; }
        private ValidationResult ValidationResult = new();


        public CustomerHandler(ICustomerRepository customerRepository, IMediator mediator)
        {
            _customerRepository = customerRepository;
            _mediator = mediator;
        }

        /// <summary>
        /// Processa a requisição assinada pelo request
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public async Task<IEnumerable<Customer>> Handle(GetAllRequest request, CancellationToken cancellationToken) =>
            await _customerRepository.GetAll().ConfigureAwait(false);





        public async Task<ValidationResult> Handle(InsertCustomerRequest request, CancellationToken cancellationToken)
        {
            // 1 - Map 
            Customer customer = new(request.Name);

            // 2  - aplicação de regras.....

            // 3  - persiste Obj Customer

            // 4 - Notifica uma nova mensagem para outro contexto;
            await _mediator.Publish(new Notification
            {
                Nome = customer.Name,
                DataHora = System.DateTime.UtcNow.AddHours(-3)
            }, cancellationToken); 
            return ValidationResult;
        }
    }
}
