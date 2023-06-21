using ElearningApi.BL.Interfaces;
using ElearningApi.BL.Services;
using ElearningApi.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Add services to the container.
string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

ContextConfiguration.ConexionString = builder.Configuration?.GetConnectionString("DBConexionSql");

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddCors(c => c.AddPolicy(MyAllowSpecificOrigins, builder => {

    builder
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials()        
        .WithOrigins("*"); //"*" "http://localhost:8080", "http://localhost:80", "http://127.0.0.1", "http://localhost"
}));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Injecciones
builder.Services.AddTransient<ICurso, CursoService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();

app.MapControllers();

app.Run();
