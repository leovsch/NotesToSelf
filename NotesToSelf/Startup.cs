using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NotesToSelf.DAL.Contexts;
using NotesToSelf.DAL.DataModels;
using NotesToSelf.DAL.Repositories.Implementations;
using NotesToSelf.DAL.Repositories.Interfaces;

namespace NotesToSelf
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // register identity server
            services.AddIdentityServer().AddDeveloperSigningCredential();

            // register db contexts
            services.AddDbContext<BaseContext<Note>>(opt => opt.UseInMemoryDatabase("NoteList"));

            // register repositories
            services.AddTransient<IBaseRepository<Note>, BaseRepository<Note>>();

            // register mvc
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
