using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator() //validation rules
        {
            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.BrandId).NotEmpty().WithMessage("brand id should not be empty");
            RuleFor(c => c.ColorId).NotEmpty().WithMessage("color id should not  be empty");
            RuleFor(c => c.ModelYear).NotEmpty().WithMessage("model year should not be empty");
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
           
        }
    }
}
