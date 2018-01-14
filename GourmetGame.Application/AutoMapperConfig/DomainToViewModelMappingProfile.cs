using AutoMapper;
using GourmetGame.Application.ViewModel;
using GourmetGame.Domain.Entities;

namespace GourmetGame.Application.AutoMapperConfig
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public DomainToViewModelMappingProfile()
        {
            CreateMap<Category, CategoryViewModel>();
            CreateMap<Dish, DishViewModel>();
        }
    }
}