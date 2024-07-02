using WebApplication2;
using Microsoft.AspNetCore.Hosting;

var builder = WebApplication.CreateBuilder(args);

// Yapýlandýrmayý Startup sýnýfýmýzda gerçekleþtiriyoruz
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();
// Configure the HTTP request pipeline.
startup.Configure(app);

app.Run();
