using AutoMapper;
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
        private IMapper _mapper;
        public GetBodyParameterDetailQueryHandler(ISanitaDbContext sanitaDbContext, IMapper mapper)
        {
            _sanitaDbContext = sanitaDbContext;
            _mapper = mapper;
        }
        public async Task<BodyParameterDetailVm> Handle(GetBodyParameterDetailQuery request, CancellationToken cancellationToken)
        {
            var bodyParameter = await _sanitaDbContext.BodyParameters.Where(b => b.UserId == request.UserId).FirstOrDefaultAsync(cancellationToken);

            var bodyParameterVm = _mapper.Map<BodyParameterDetailVm>(bodyParameter);

            return bodyParameterVm;
        }
    }
}
