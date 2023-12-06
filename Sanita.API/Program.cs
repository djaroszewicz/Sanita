var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(option =>
    option.AddPolicy(name: "MyAllowSpecificOrigin", builder =>
    {
        builder.AllowAnyOrigin();
        //builder.WithOrigins("https://localhost:7001");
    }));

//Tutaj cala konfiguracja zmieni sie w pozniejszym etapie
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo
    {
        Title = "Sanita",
        Version = "v1",
        Description = "Web API",
        TermsOfService = new Uri("https://example.com/terms"),
        Contact = new Microsoft.OpenApi.Models.OpenApiContact
        {
            Name = "Dawid",
            Email = string.Empty,
            Url = new Uri("https://example.com/terms"),
        },
        License = new Microsoft.OpenApi.Models.OpenApiLicense
        {
            Name = "Used License",
            Url = new Uri("https://example.com/license")
        }
    });
    var filePath = Path.Combine(AppContext.BaseDirectory, "Sanita.xml");
    c.IncludeXmlComments(filePath);
});

builder.Services.AddHealthChecks();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors();
app.UseHealthChecks("/hc");
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
