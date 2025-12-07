using Library.Application.DependencyResolvers;
using Library.InnerInfrastructure.DependencyResolvers;
using Library.Presistence.DependencyResolvers;
using Library.ValidatorStructor.DependencyResolvers;
using Library.WebApi.DependencyResolvers;

namespace Library.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddApplicationServices();
            builder.Services.AddManagerServices();
            builder.Services.AddPersistenceServices(builder.Configuration);
            builder.Services.AddValidatorService();
            builder.Services.AddVmMapperService();

            var app = builder.Build();

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
