using AutoMapper;
using gallery_netcore.Controllers.Resource;
using gallery_netcore.Controllers.Resources;
using gallery_netcore.Models;

namespace gallery_netcore.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryResource>();
            CreateMap<Post, PostResource>();
        }
    }
}