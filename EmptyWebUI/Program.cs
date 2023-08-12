var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Endpoint: Ýlgili localhost portundan giriþ yapýldýðýnda gelen tek cevaptýr.
app.MapGet("/", () => "Hello World!");

app.Run();
