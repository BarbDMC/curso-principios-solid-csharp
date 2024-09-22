using DependencyInversion;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Tipos de ciclo de vida para la inyección de dependencias:
// 1. AddTransient: los servicios con este ciclo de vida se crean cada vez que son solicitados. Ideal para servicios livianos y sin estado.
// 2. AddScoped: los servicios se crean una sola vez por cada solicitud HTTP. Se reutilizan durante toda la vida de la misma solicitud.
// 3. AddSingleton: los servicios se crean la primera vez que son solicitados o cuando se ejecuta ConfigureServices (si se especifica una instancia allí).
//    La misma instancia es reutilizada en todas las solicitudes posteriores.

// Configuramos la inyección de dependencias para las interfaces y sus implementaciones.
// IStudentRepository usa StudentRepository y ILogbook usa Logbook.
// Cada servicio se creará una vez por solicitud (Scoped).
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ILogbook, Logbook>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
        options.RoutePrefix = string.Empty;
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
