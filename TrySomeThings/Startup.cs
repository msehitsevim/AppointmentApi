using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Ts.DAL;
using Ts.DAL.Entities;

namespace BaseProject
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
            services.AddScoped<MsSqlRepository<Patient>>();
            services.AddScoped<MsSqlRepository<Appointment>>();
            services.AddControllers();
            services.AddControllers()
           .AddJsonOptions(options =>
              options.JsonSerializerOptions.PropertyNamingPolicy = null);
            //services
            //    .AddMvc()
            //    .AddJsonOptions(opt => opt.JsonSerializerOptions.ContractResolver
            //        = new DefaultContractResolver());
            services.AddCors();
            services.AddDbContext<MsDbContext>(opt =>
            {
                opt.UseSqlServer(Configuration.GetConnectionString("MsDbAddress"), y => y.MigrationsAssembly("BaseProject"));
            });


            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "AppointmentServices", Version = "v1" });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "BaseProject v1"));
            }
            app.UseCors(cors =>
            {
                cors
                 .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowAnyOrigin();
            });
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
