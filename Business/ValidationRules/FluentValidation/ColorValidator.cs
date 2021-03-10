using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator :AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(b => b.ColorName).MinimumLength(2).WithMessage("color name should be greater than 2 characters.");
        }
    }
}
