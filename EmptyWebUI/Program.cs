using Service;
using Service.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();//RazorPages UI yapýsýdýr, css,js vb dosyalarýnda konumu belirtilmelidir.

builder.Services.AddAWServices(builder.Configuration.GetConnectionString("AW14"));


var app = builder.Build();

app.UseStaticFiles();//wwwroot klasörünü arar, içindeki tüm statik dosyalarý haritalandýrýr.
app.UseHttpsRedirection();

//Endpoint: Ýlgili localhost portundan giriþ yapýldýðýnda gelen tek cevaptýr.
//app.MapGet("/", ()=>"Hello World!!!");

app.MapRazorPages();//Pages isimli klasörü arar, içinde bulunan tüm razorpage yapýlarýný haritalandýrýr..

app.Run();
