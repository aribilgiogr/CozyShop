using AutoMapper;

namespace Business
{
    public static class AutoMapperConfig
    {
        private static IMapper mapper;

        public static IMapper Mapper
        {
            get
            {
                if (mapper == null)
                {
                    throw new System.Exception("Automapper not initialized. Call Initialize() first.");
                }

                return mapper;
            }
        }

        public static void Initialize()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<Profiles.ProductProfile>();
            });
            mapper = config.CreateMapper();
        }
    }
}
