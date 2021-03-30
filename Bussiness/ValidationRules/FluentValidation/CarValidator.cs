using Entities.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Name).MinimumLength(2).WithMessage("Araç ismi 2 karakterden büyük olmalı");
            RuleFor(p => p.DailyPrice).GreaterThan(100).WithMessage("Kiralama bedeli 100 TL den fazla olmalı");
            RuleFor(p => p.ModelYear).NotEmpty();
            RuleFor(p => p.BrandId).NotEmpty();
            RuleFor(p => p.ColorId).NotEmpty();
            RuleFor(p => p.DailyPrice).NotEmpty();      
        }
    }
}
