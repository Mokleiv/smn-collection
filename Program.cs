using HomeAPI.Data.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddPooledDbContextFactory<ApplicationDbContext>(
    options => options.UseSqlite("Data Source=home.db"));

builder.Services
    .AddGraphQLServer();

var app = builder.Build();

app.MapGraphQL();

app.Run();
