using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Category Name can not empty");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Category Description can not empty");
            RuleFor(x => x.CategoryName).MinimumLength(2).WithMessage("Min 2 char");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Max 50 char");
        }
    }
}
