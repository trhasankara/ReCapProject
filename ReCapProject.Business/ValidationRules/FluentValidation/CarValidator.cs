using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using FluentValidation;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).NotNull();
            RuleFor(p => p.Name).MinimumLength(2);
            RuleFor(p => p.DailyPrice).GreaterThan(0);
        }
    }
}
