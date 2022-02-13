using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VangelAuto.Data.Models;
using VangelAuto.Services.Dto;

namespace VangelAuto.Api.Validators
{
    public class CarModelValidator : AbstractValidator<CarModelDto>
    {
        public CarModelValidator()
        {
            RuleFor(cm => cm.MakeName).NotEmpty().MinimumLength(4);
            RuleFor(cm => cm.ModelName).NotEmpty().MinimumLength(4);
        }
    }
}
