using MediatRSampleApi.DependencyInjection;
using MediatRSampleApi.Repository;

namespace MediatRSampleApi;

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
          builder.Services.AddSingleton<ICustomerRepository>(new CustomerRepository());
          builder.Services.RegisterRequestHandlers();

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