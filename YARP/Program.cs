var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile(Path.Combine(builder.Environment.ContentRootPath, "config.json"), false, true);
builder.Services.AddReverseProxy().LoadFromConfig(builder.Configuration.GetRequiredSection("ReverseProxy"));

var app = builder.Build();
app.MapReverseProxy();
app.Run();
