using BLL.Interfaces;
using BLL.Services;
using DAL.DAL;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});
builder.Services.AddControllers();

builder.Services.AddScoped<IReminderRepository, ReminderRepository>(); 
builder.Services.AddScoped<ReminderService>();

var app = builder.Build();

app.MapGet("/", () => "Back-end running");
app.UseCors("AllowAll");
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.Run();
