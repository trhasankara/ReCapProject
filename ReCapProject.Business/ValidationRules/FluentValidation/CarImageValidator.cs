using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using ReCapProject.Entities.Concrete;

namespace ReCapProject.Business.ValidationRules.FluentValidation
{
    public class CarImageValidator:AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            //RuleFor(p => p.ImagePath).NotNull();
            //RuleFor(p => p.ImagePath).NotEmpty();
        }
    }
}
