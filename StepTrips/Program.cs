using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StepTrips.Business.Service.Client_Implementation;
using StepTrips.DataAccess;
using StepTrips.DataContract.Interface.Client_Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//AutoMapper Injiction
builder.Services.AddAutoMapper(typeof(Program).Assembly);

//Interfaces Injictions
builder.Services.AddScoped<ISeatsCalculations, SeatsCalculation>();
builder.Services.AddScoped<IClientAddReservation, ClientAddReservation>();

//Context Injition
builder.Services.AddDbContext<ApplicationDbContext>
    (Options => Options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionDb")));


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
    pattern: "{controller=ClientMain}/{action=Index}/{id?}");

app.Run();
