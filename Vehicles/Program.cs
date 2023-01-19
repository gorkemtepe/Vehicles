using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Vehicles.Core.Entities;
using Vehicles.Core.Repository;

namespace Vehicles
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<VehicleRepository>();
            builder.Services.AddDbContext<AppDBContext>(x =>
            {
                x.UseSqlServer(builder.Configuration.GetConnectionString("SqlConnection"), option =>
                {
                    //option.MigrationsAssembly("NLayer.Repository"); veya Tip korumalý olarak aþaðýdaki kod kullanýlabilir.
                    option.MigrationsAssembly(Assembly.GetAssembly(typeof(AppDBContext)).GetName().Name);
                });
            });
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