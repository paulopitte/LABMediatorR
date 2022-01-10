using FluentValidation;
using LABMediatR.Requests;

namespace LABMediatR.Domain.Validations
{
    public abstract class CustomerValidation<T> : AbstractValidator<T> where T : InsertCustomerRequest
    {
        protected void ValidationName()
        {
            RuleFor(c => c.Name)
                   .NotEmpty()
                   .WithMessage("O Nome é obrigátorio!")
                   .WithErrorCode("Customer.Name.Empty")
                   .Length(10, 255)
                   .WithMessage("Nome deve ter entre 6 e 255 caracteres")
                   .WithErrorCode("Customer.Name.BetterThanMaximun");
        }
    }
}
