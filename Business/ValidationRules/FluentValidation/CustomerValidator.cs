using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CustomerValidator :AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.CompanyName).MinimumLength(2).WithMessage("company name shoud be greater than 2 characters.");
            RuleFor(c => c.UserId).NotEmpty().WithMessage("user id should not be empty.");
        }
    }
}
