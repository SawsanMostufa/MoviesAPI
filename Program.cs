using Microsoft.EntityFrameworkCore;
using MoviesAPI.Models;

var builder = WebApplication.CreateBuilder(args);
var connectionstring=builder.Configuration.GetConnectionString(name:"DefaultConnection");   
// Add services to the container.
builder.Services.AddDbContext<Dbcontext>(options =>
options.UseSqlServer(connectionstring)
) ;
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

app.UseAuthorization();

app.MapControllers();

app.Run();
