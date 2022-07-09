using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.ValidationRules
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(a => a.AuthorName).NotEmpty().WithMessage("Name & Lastname cannot be empty please fill it");
            RuleFor(a => a.AuthorMail).NotEmpty().WithMessage("Email cannot be empty please fill it");
            RuleFor(a => a.AuthorPassword).NotEmpty().WithMessage("Password cannot be empty please fill it");
            RuleFor(a => a.AuthorName).MinimumLength(2).WithMessage("Enter at least 2 characters");
            RuleFor(a => a.AuthorPassword).MinimumLength(2);
            RuleFor(a => a.AuthorPassword).MaximumLength(12);
            //RuleFor(a=>a.AuthorPassword).Matches("^(?=.*[0-9])(?=.*[a-zA-Z])([a-zA-Z0-9]+)$").WithMessage("regex error");
        }
    }
}
