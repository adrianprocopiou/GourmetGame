namespace GourmetGame.Application.AutoMapperConfig
{
    public class AutoMapperConfig
    {
        public static void RegisterMapping()
        {
            AutoMapper.Mapper.Initialize(x =>
            {
                x.AddProfile<ViewModelToDomainMappingProfile>();
                x.AddProfile<DomainToViewModelMappingProfile>();
            });
        }
    }
}