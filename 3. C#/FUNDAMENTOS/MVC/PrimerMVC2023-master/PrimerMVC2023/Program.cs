using PrimerMVC2023.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//AQUI REALIZAMOS IoC CON LOS OBJETOS 
//QUE RECIBEN LOS CONTROLADORES O EL RESTO DE CLASES
//EN SU CONSTRUCTOR
//CREAMOS UN NUEVO COCHE
Coche car = new Coche();
car.Marca = "DMG";
car.Modelo = "DELOREAN";
car.Imagen = "delorean.jpg";
car.Velocidad = 0;
car.VelocidadMaxima = 240;
//UNA VEZ CREADO, ENVIAMOS EL COCHE PARA QUE SEA UTILIZADO
builder.Services.AddTransient<Coche>(z => car);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
