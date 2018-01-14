using AutoMapper;
using GourmetGame.Application.ViewModel;
using GourmetGame.Domain.Entities;

namespace GourmetGame.Application.AutoMapperConfig
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            CreateMap<CategoryViewModel, Category>();
            CreateMap<DishViewModel, Dish>();
        }
    }
}