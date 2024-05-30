using MyPage.Components;
using MyPage.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using MyPage.Service;
using BookLibrary.Service;
using BlazorBootstrap;
using MudBlazor.Services;



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//mudblazor
builder.Services.AddMudServices();

builder.Services.AddDbContext<PageDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.")));

builder.Services.AddQuickGridEntityFrameworkAdapter();;

builder.Services.AddBlazorBootstrap();
//builder.Services.AddScoped<ToastService>();

builder.Services.AddSingleton<LoginService>();
builder.Services.AddScoped<OpenLibraryService>();

// Inside ConfigureServices method of Startup.cs
builder.Services.AddHttpClient<OpenLibraryService>(client =>
{
    client.BaseAddress = new Uri("http://openlibrary.org/");
});

builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddServerSideBlazor().AddCircuitOptions(options => { options.DetailedErrors = true; });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
