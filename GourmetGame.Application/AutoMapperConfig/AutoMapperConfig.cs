using AutoMapper;

namespace GourmetGame.Application.AutoMapperConfig
{
    public class AutoMapperConfig
    {
        public static void RegisterMapping()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<ViewModelToDomainMappingProfile>();
                x.AddProfile<DomainToViewModelMappingProfile>();
            });
        }
    }
}