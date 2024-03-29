﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Application.BodyParameters.Queries.GetBodyParameterDetail
{
    public class GetBodyParameterDetailQuery : IRequest<BodyParameterDetailVm>
    {
        public int UserId { get; set; }
    }
}
