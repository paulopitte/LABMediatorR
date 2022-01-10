using FluentValidation.Results;
using LABMediatR.Domain.Validations;
using MediatR;
using System;

namespace LABMediatR.Requests
{
    public class InsertCustomerRequest : IRequest<ValidationResult>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ValidationResult ValidationResult = new();

        public bool IsValid()
        {
            ValidationResult = new CustomerCreateValidation().Validate(this);
            return ValidationResult.IsValid;

        }
    }
}
