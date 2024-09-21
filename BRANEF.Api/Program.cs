using BRANEF.Application.DependencyInjection;
using BRANEF.Infra.EntityFramework;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddApplication();
builder.Services.AddRepositories();

// TODO: remover string de conexão para vault
builder.Services.AddDbContext<BranefContext>(options => options.UseSqlServer("Server=IUGRAM\\SQLEXPRESS22;Initial Catalog=BRANEF;User ID=sa;Password=1234;Trust Server Certificate=True"));

var app = builder.Build();

// HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();


