var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//Endpoint: �lgili localhost portundan giri� yap�ld���nda gelen tek cevapt�r.
app.MapGet("/", () => "Hello World!");

app.Run();
