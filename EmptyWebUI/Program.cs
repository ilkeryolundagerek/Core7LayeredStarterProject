using Service;
using Service.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();//RazorPages UI yap�s�d�r, css,js vb dosyalar�nda konumu belirtilmelidir.

builder.Services.AddAWServices(builder.Configuration.GetConnectionString("AW14"));


var app = builder.Build();

app.UseStaticFiles();//wwwroot klas�r�n� arar, i�indeki t�m statik dosyalar� haritaland�r�r.
app.UseHttpsRedirection();

//Endpoint: �lgili localhost portundan giri� yap�ld���nda gelen tek cevapt�r.
//app.MapGet("/", ()=>"Hello World!!!");

app.MapRazorPages();//Pages isimli klas�r� arar, i�inde bulunan t�m razorpage yap�lar�n� haritaland�r�r..

app.Run();
