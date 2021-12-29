using FluentValidation;
using Mc.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mc.Manager.Validator
{
    public class ClientValidator : AbstractValidator<Client>
    {
        public ClientValidator()
        {
            RuleFor(x => x.Name).NotNull().NotEmpty().MinimumLength(10).MaximumLength(150);
            RuleFor(x => x.BirthDate).NotNull().NotEmpty().LessThan(DateTime.Now).GreaterThan(DateTime.Now.AddYears(-130));
            RuleFor(x => x.CPF).NotNull().NotEmpty().Matches("[2-9][0-9]{10}").WithMessage("CPF");
            RuleFor(x => x.Tel).NotNull().MinimumLength(11);
            RuleFor(x => x.Gender).Must(IsGender);
        }


        private bool IsGender(char? gender)
        {
            return gender == 'M' || gender == 'F' || gender == 'O';
        }
    }
}
