using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VangelAuto.Data.Models;
using VangelAuto.Services.Dto;

namespace VangelAuto.Api.Validators
{
    public class CategoryValidator : AbstractValidator<CategoryDto>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name).NotEmpty().MinimumLength(4);
        }
    }
}
