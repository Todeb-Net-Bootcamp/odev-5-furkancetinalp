using DTO.Customer;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Validator.CustomerValidator
{
    //Validation criteria specification to update a customer
    public class UpdateCustomerRequestValidator:AbstractValidator<UpdateCustomerRequest>
    {
        public UpdateCustomerRequestValidator()
        {
            RuleFor(x=>x.Surname).NotEmpty();
            RuleFor(x=>x.Name).NotEmpty();
            RuleFor(x=>x.IdentityNumber).NotEmpty();
            RuleFor(x => x.CustomerListId).GreaterThan(0);
        }
    }
}
