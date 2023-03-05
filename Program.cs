using webapi;

var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Configuration);

startup.ConfigureServices(builder.Services);

// La inyeccion de dependencias se hace aquí 
// builder.Services.AddScoped<IHelloWorldService, HelloWroldService>();

var app = builder.Build();

startup.Configure(app, app.Environment);

app.Run();
