using ServiceLifetimeDemonstration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Host.UseDefaultServiceProvider(options=>options.ValidateScopes=false);

builder.Services.AddRazorPages();

var services= builder.Services;

services.AddRazorPages();
//services.AddScoped<IGuidService, GuidService>();
//services.AddTransient<IGuidService, GuidService>();
services.AddSingleton<IGuidService, GuidService>();

services.AddSingleton<IGuidTrimmer,GuidTrimmer>();
services.AddScoped<DisposableService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseMiddleware<CustomMiddleware>();

app.MapRazorPages();

app.Run();
