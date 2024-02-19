using MediatR;
using Microsoft.EntityFrameworkCore;
using Sanita.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Application.BodyParameters.Queries.GetBodyParameterDetail
{
    public class GetBodyParameterDetailQueryHandler : IRequestHandler<GetBodyParameterDetailQuery, BodyParameterDetailVm>
    {
        private readonly ISanitaDbContext _sanitaDbContext;
        public GetBodyParameterDetailQueryHandler(ISanitaDbContext sanitaDbContext)
        {
            _sanitaDbContext = sanitaDbContext;
        }
        public async Task<BodyParameterDetailVm> Handle(GetBodyParameterDetailQuery request, CancellationToken cancellationToken)
        {
            var bodyParameter = await _sanitaDbContext.BodyParameters.Where(b => b.UserId == request.UserId).FirstOrDefaultAsync(cancellationToken);

            var bodyParameterVm = new BodyParameterDetailVm
            {
                Weigth = bodyParameter.Weigth,
                Heigth = bodyParameter.Heigth,
                Neck = bodyParameter.Neck,
                Chest = bodyParameter.Chest,
                Waist = bodyParameter.Waist,
                Stomach = bodyParameter.Stomach,
                Hips = bodyParameter.Hips,
                Biceps = bodyParameter.Biceps,
                Forearm = bodyParameter.Forearm,
                Thigh = bodyParameter.Thigh,
                Calf = bodyParameter.Calf
            };

            return bodyParameterVm;
        }
    }
}
