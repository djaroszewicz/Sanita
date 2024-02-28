using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Application.BodyParameters.Commands.CreateBodyParameter
{
    public class CreateBodyParameterCommandValidator : AbstractValidator<CreateBodyParameterCommand>
    {
        public CreateBodyParameterCommandValidator() 
        {
            RuleFor(x => x.Weigth).GreaterThan(1);
        }

    }
}
