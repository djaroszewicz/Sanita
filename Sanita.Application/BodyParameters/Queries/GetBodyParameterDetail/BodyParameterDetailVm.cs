using AutoMapper;
using Sanita.Application.Common.Mappings;
using Sanita.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Application.BodyParameters.Queries.GetBodyParameterDetail
{
    public class BodyParameterDetailVm : IMapFrom<BodyParameter>
    {
        public decimal CalfExtended { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<BodyParameter, BodyParameterDetailVm>()
                .ForMember(bp => bp.CalfExtended, map => map.MapFrom(src => src.Calf));
            //.ForMember(bp => bp.Zagniezdzenie, map => map.MapFrom<LastCalfResolver>());
        }

        //// Resolver to checking values if not empty or something in if
        //private class LasCalfResolver : IValueResolver<BodyParameter, object, string>
        //{
        //    public string Resolve(BodyParameter source, object destination, string destMember, ResolutionContext context)
        //    {
        //        if(source.Zagniezdzenie is not null && source.Zagniezdzenie.Any())
        //        {
        //            var checkingValue = source.Zagniezdzenie.OrderByDescending(p => p.Value).FirstOrDefault();
        //            return checkingValue.Value;
        //        }
        //        return string.Empty;
        //    }
        //}
    }
}
