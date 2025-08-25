using Microsoft.EntityFrameworkCore;

using PoneyHub.Application.Context;
using PoneyHub.Application.Services;
using PoneyHub.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IPoneyService, PoneyService>();

builder.Services.AddDbContext<IPoneyHubDbContext, PoneyHubDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("PoneyHubDbContext"));
});

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<IPoneyHubDbContext>();

    if (!context.Database.CanConnect())
    {
        throw new NotImplementedException();
    }
}

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