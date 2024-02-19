using MediatR;
using Microsoft.EntityFrameworkCore;
using Sanita.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Application.BodyParameters.Commands.DeleteBodyParameter
{
    public class DeleteBodyParameterCommandHandler : IRequestHandler<DeleteBodyParameterCommand, Unit>
    {
        private readonly ISanitaDbContext _sanitaDbContext;

        public DeleteBodyParameterCommandHandler(ISanitaDbContext sanitaDbContext) {
            _sanitaDbContext = sanitaDbContext;
        }

        public async Task<Unit> Handle(DeleteBodyParameterCommand request, CancellationToken cancellationToken)
        {
            var bodyParameter = await _sanitaDbContext.BodyParameters.Where(bp => bp.Id == request.BodyParameterId).FirstOrDefaultAsync(cancellationToken);

            _sanitaDbContext.BodyParameters.Remove(bodyParameter);

            await _sanitaDbContext.SaveChangesAsync(cancellationToken);
            
            return Unit.Value;
        }

    }
}
