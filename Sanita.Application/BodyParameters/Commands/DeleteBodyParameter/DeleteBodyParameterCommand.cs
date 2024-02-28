using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Application.BodyParameters.Commands.DeleteBodyParameter
{
    public class DeleteBodyParameterCommand : IRequest<Unit>
    {
        public int BodyParameterId { get; set; }
    }
}
