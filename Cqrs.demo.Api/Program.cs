using Cqrs.demo.Core.Mapping;

using Cqrs.demo.Core.UserProfiles.Queries;

using Cqrs.demo.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<PostContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostDb"));
});
builder.Services.AddMediatR(typeof(GetAllUserProfiles));

builder.Services.AddTransient<UserProfileMapper>();

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