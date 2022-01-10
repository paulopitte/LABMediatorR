using LABMediatR.Requests;

namespace LABMediatR.Domain.Validations
{
    public class CustomerCreateValidation : CustomerValidation<InsertCustomerRequest>
    {
        public CustomerCreateValidation()
        {
            ValidationName();
        }
    }
}
