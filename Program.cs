
using Microsoft.EntityFrameworkCore;
using VCA.Services.Segments;
using VCA.Repositories;
using VCA.Services;
using VCA.Services.Manufaturers;
using Microsoft.EntityFrameworkCore.Metadata;
using VCA.Services.Verient;
using Microsoft.EntityFrameworkCore.Internal;
using VCA.Services.Registrations;
using VCA.Services.AlternateComponent;

namespace VCA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            
            builder.Services.AddTransient<ISegmentService, SegmentServiceImpl>();
            builder.Services.AddTransient<IManufacturerRepository, ManufacturerRepository>();
            builder.Services.AddTransient<IModelRepository,ModelRepository>();
            builder.Services.AddTransient<IRegistrationRepository,RegistrationRepository>();
            builder.Services.AddTransient<IComponentRepository,ComponentRepository>();
            builder.Services.AddTransient<IAlternateComponentRepository, AlternateComponentRepository>();
            builder.Services.AddDbContext<AppDbContext>(option => option.UseSqlServer(builder.Configuration.GetConnectionString("EmployeeDBConnection")));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddCors(options =>
            {
                options.AddPolicy("MyAllowSpecificOrigins",
                                  builder =>
                                  {
                                     // builder.WithOrigins("http://127.0.0.1:5500")
                                      builder.WithOrigins("*")
                                      .AllowAnyHeader()
                                      .AllowAnyMethod();
                                  });
            })
            ;
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();

            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseCors("MyAllowSpecificOrigins");

            app.MapControllers();

            app.Run();
        }
    }
}