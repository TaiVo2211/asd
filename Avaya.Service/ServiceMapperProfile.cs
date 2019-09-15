using AutoMapper;
using Avaya.Domain.Models;
using Avaya.Model;
using Avaya.Model.Movie;

namespace Avaya.Service
{
    public class ServiceMapperProfile : Profile
    {
        public ServiceMapperProfile()
        {
            var config = new MapperConfiguration(cfg => {
                //cfg.CreateMap<ProductDetails, ProductDetailModel>();
                //cfg.CreateMap<Movie, MovieModel>()
                //    .ForMember(x => x.Duration, m => m.MapFrom(i => i.Duration * 10)).ReverseMap();
            });
        }
    }
}
