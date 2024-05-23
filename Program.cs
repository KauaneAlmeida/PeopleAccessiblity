using DisabledPeopleRegister;
using DisabledPeopleRegister.Repositories;
using DisabledPeopleRegister.Repositories.Contracts;
using DisabledPeopleRegister.Services;
using DisabledPeopleRegister.Services.Contracts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

string dbConnection = builder.Configuration.GetConnectionString("OracleConnection")!;

builder.Services.AddDbContext<DatabaseContext>(options => options.UseOracle(dbConnection));

//User services
builder.Services.AddTransient<IUsersService, UserService>();
builder.Services.AddTransient<IUsersRepository, UserRepository>();

//Activities services
builder.Services.AddTransient<IActivitiesService, ActivitiesService>();
builder.Services.AddTransient<IActivitiesRepository, ActivitiesRepository>();



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

app.Run();
