using Entities.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<Photo>
    {
        public CarImageValidator()
        {
            RuleFor(p => p.CarId).NotEmpty();

        }
    }
}
