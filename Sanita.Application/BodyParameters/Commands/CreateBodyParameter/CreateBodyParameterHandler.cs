using MediatR;
using Sanita.Application.Common.Interfaces;
using Sanita.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Application.BodyParameters.Commands.CreateBodyParameter
{
    public class CreateBodyParameterHandler : IRequestHandler<CreateBodyParameterCommand, int>
    {
        private readonly ISanitaDbContext _sanitaDbContext;

        public CreateBodyParameterHandler(ISanitaDbContext sanitaDbContext)
        {
            _sanitaDbContext = sanitaDbContext;
        }

        public async Task<int> Handle(CreateBodyParameterCommand request, CancellationToken cancellationToken)
        {
            BodyParameter bodyParameter = new()
            {
                UserId = 1,
                Weigth = request.Weigth,
                Heigth = request.Heigth,
                Neck = request.Neck,
                Chest = request.Chest,
                Waist = request.Waist,
                Stomach = request.Stomach,
                Hips = request.Hips,
                Biceps = request.Biceps,
                Forearm = request.Forearm,
                Thigh = request.Thigh,
                Calf = request.Calf
            };

            _sanitaDbContext.BodyParameters.Add(bodyParameter);

            await _sanitaDbContext.SaveChangesAsync(cancellationToken);
            return bodyParameter.Id;
        }
    }
}
