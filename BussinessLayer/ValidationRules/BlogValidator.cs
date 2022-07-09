using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog title can't be empty");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog content cant be empty");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Blog Image cant be empty");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog content cant be empty");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Min 5 char");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Max 150 char");
        }
    }
}
