var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "East India Trading Co.!");

app.Run();
