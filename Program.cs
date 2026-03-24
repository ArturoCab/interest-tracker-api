using GameInterestApi.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<AppDbContext> (options => options.UseSqlite("Data Source=gameinterest.db"));

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options=>
{
   options.AddPolicy("AllowAll",
        policy=> policy.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader()); 
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("AllowAll");
app.MapControllers();
app.Run();