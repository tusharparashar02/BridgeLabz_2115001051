using BusinessLayer.Service;
using RepositoryLayer.Service;

using BusinessLayer.Interface;
using RepositoryLayer.Interface;
using RepositoryLayer.Context;
using Microsoft.EntityFrameworkCore;
using NLog;
using NLog.Web;

var logger= LogManager.Setup().LoadConfigurationFromAppSettings().GetCurrentClassLogger();
logger.Info("Application is starting");

try
{
    var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.

    builder.Services.AddControllers();
    builder.Services.AddScoped<IUserRegistration, UserRegistration>();
    builder.Services.AddScoped<IUserRepository, UserRepository>();

    //Database connection
    var connectionSring = builder.Configuration.GetConnectionString("SqlConnection");
    builder.Services.AddDbContext<UserRegistrationSystemContext>(options => options.UseSqlServer(connectionSring));


    //Add swagger to container
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    var app = builder.Build();

    app.UseSwagger();
    app.UseSwaggerUI(); //configer the Http request pipeline

    // Configure the HTTP request pipeline.

    app.UseHttpsRedirection();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();

}
catch(Exception ex)
{
    logger.Error(ex, "Application stopped due to exception");
}

finally
{
    LogManager.Shutdown();
}