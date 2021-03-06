using Inta.Validation.Model;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddSwaggerDocument();
builder.Services.AddDbContext<DatabaseContext>();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();
app.UseOpenApi();
app.UseSwaggerUi3();
app.MapControllers();

app.Run();
