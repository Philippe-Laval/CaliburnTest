using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

using FluentValidation;

namespace Caliburn.Micro.FluentValidation
{
    class ShellValidator : AbstractValidator<ShellViewModel>
    {
        public ShellValidator()
        {
            RuleFor(shell => shell.Name)
                .NotEmpty()
                .WithMessage("Please Specify a Name.");

            RuleFor(shell => shell.Email)
                .EmailAddress()
                .WithMessage("Please Specify a Valid E-Mail Address");

            RuleFor(shell => shell.Zip)
                .Must(BeAValidZip)
                .WithMessage("Please Enter a Valid Zip Code");
        }

        private static bool BeAValidZip(string zip)
        {
            if (!string.IsNullOrEmpty(zip))
            {
                var regex = new Regex(@"\d{5}");
                return regex.IsMatch(zip);
            }
            return false;
        }
    }
}
