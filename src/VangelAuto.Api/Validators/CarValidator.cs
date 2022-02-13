using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VangelAuto.Data.Models;
using VangelAuto.Services.Dto;

namespace VangelAuto.Api.Validators
{
    public class CarValidator : AbstractValidator<CreateCarDto>
    {
        public CarValidator()
        {
            RuleFor(c => c.Name).NotEmpty().MinimumLength(3);
            RuleFor(c => c.ModelId).NotEmpty();
        }
    }
}
