using AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace NotesToSelf.BLL.AutoMapper.Config
{
    public static class AutoMapperConfig
    {
        public static void ConfigAutoMapper(IServiceCollection services)
        {
            services.AddAutoMapper();
        }
    }
}
