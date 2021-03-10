using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator :AbstractValidator<Rental>

    {
        public RentalValidator()
        {
            RuleFor(r => r.CarId).NotEmpty().WithMessage("car id should not be empty");
            RuleFor(r => r.CustomerId).NotEmpty().WithMessage("customer id should not be empty");
            RuleFor(r => r.RentDate).NotEmpty().WithMessage("rent date should not be empty");
         
        }

      
    }
}
