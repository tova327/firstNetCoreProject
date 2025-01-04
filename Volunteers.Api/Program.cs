using Microsoft.AspNetCore.Cors.Infrastructure;
using System.Text.Json.Serialization;
using volunteers.Service;
using Volunteers.Core.entities;
using Volunteers.Core.InterfaceService;
using Volunteers.Core.InterfaseRepository;
using Volunteers.Data;
using Volunteers.Data.repositories;


namespace Volunteers.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            
            builder.Services.AddScoped<IGenericService<UserEntity>, UsersService>();
            builder.Services.AddScoped<IGenericService<VolunteerInActivityEntity>, volunteerInActivityService>();
            builder.Services.AddScoped<IGenericService<ActivityEntity>, ActivitiesService>();
            builder.Services.AddScoped<IGenericService<OrgEntity>, OrgService>();
            builder.Services.AddScoped<IGenericRepository<OrgEntity>, OrgRepository>(); 
            builder.Services.AddScoped<IGenericRepository<UserEntity>, UsersRepository>(); 
            builder.Services.AddScoped<IGenericRepository<ActivityEntity>, ActivityRepository>(); 
            builder.Services.AddScoped<IGenericRepository<VolunteerInActivityEntity>, VolunteerInActivityRepository>();
            
            builder.Services.AddDbContext<DataContext>();
            //builder.Services.AddSingleton<DataContext>();


            builder.Services.AddControllers().AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
                options.JsonSerializerOptions.WriteIndented = true;
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}