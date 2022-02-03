var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<Context>(c => new Context(builder.Configuration.GetConnectionString("Default")));
builder.Services.AddScoped<ICompanyService, CompanyService>();
builder.Services.AddCors();

var app = builder.Build();

app.UseMiddleware<ExceptionHandlerMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors(x => x.AllowAnyMethod()
                  .AllowAnyHeader()
                  .AllowAnyOrigin());

app.MapCompanyEndpoints();

app.Run();