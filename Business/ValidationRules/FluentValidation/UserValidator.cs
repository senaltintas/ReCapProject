using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator :AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.FirstName).NotEmpty().WithMessage("first name should not be empty");
            RuleFor(u => u.LastName).NotEmpty().WithMessage("last name should not be empty");
            RuleFor(u => u.Password).MinimumLength(8).WithMessage("password should be minimum 8 characters.");
            RuleFor(u => u.Email).Must(containss).WithMessage("eposta adress is not valid.");

        }

        private bool containss(string arg)
        {
            return arg.Contains("@");
        }
    }
}
