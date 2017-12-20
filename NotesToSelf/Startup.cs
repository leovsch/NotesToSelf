using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NotesToSelf.BLL.Services.Implementations;
using NotesToSelf.BLL.Services.Interfaces;
using NotesToSelf.BLL.ViewModels;
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
            // register db contexts
            string conString = Configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<BaseContext<Note>>(opt => opt.UseSqlServer(conString));

            // register repositories
            services.AddTransient<IBaseRepository<Note>, BaseRepository<Note>>();
            services.AddTransient<INoteService, NoteService>();

            // register nuget and other services
            services.AddIdentityServer().AddDeveloperSigningCredential();
            services.AddAutoMapper();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc(routes =>
            {
                routes.MapRoute("default", "{controller=Notes}/{action=Index}/{id?}");
            });
        }
    }
}
