
using Microsoft.EntityFrameworkCore;
using Microsoft.Net.Http.Headers;
using webMusikAPI.Models;

namespace webMusikAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var myDefault = "_myDefault";
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            // connect to the database
            builder.Services.AddDbContext<WebMusikContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("WebMusik"));
            });

            builder.Services.AddCors(options =>
            {
                options.AddPolicy(myDefault, policy =>
                {
                    policy.WithOrigins("http://localhost:3000")
                    .AllowAnyMethod()
                    .AllowAnyHeader();
                });
            });

            builder.Services.AddControllers();
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

            app.UseCors(myDefault);

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
