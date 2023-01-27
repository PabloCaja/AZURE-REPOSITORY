using Microsoft.EntityFrameworkCore;
using RolPrueba1.Data;
using RolPrueba1.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

String cadena = builder.Configuration.GetConnectionString("sqlcriaturas");
RepositorySeres repo = new RepositorySeres(cadena);
builder.Services.AddTransient<RepositorySeres>(x => repo);
    
string connectionString = builder.Configuration.GetConnectionString("sqlcriaturas");
builder.Services.AddTransient<RepositoryFichapj>();


//LAS CLASES CONTEXT DE ACCESO A DATOS UTILIZAN
//UN METODO ESPECIAL LLAMADO AddDbContext
builder.Services.AddDbContext<FichapjContext>
    (options => options.UseSqlServer(connectionString));



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
