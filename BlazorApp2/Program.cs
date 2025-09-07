using BlazorApp2.Services;
using BlazorApp2.CQRS.Commands;
using BlazorApp2.CQRS.Handlers;
using BlazorApp2.CQRS.Infrastructure;
using MongoDB.Driver;
using BlazorApp2.Data;
using Microsoft.EntityFrameworkCore;
using BlazorApp2.Components;



var builder = WebApplication.CreateBuilder(args);


// Mongo
builder.Services.AddSingleton<IMongoClient>(sp =>
{
    return new MongoClient("mongodb://localhost:27017");
});


builder.Services.AddSingleton<UserService>();


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//  SQL Server
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));


builder.Services.AddScoped<UserService>();

//  CQRS
builder.Services.AddScoped<ICommandHandler<CreateUserCommand, Guid>, CreateUserHandler>();
builder.Services.AddScoped<CommandDispatcher>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();



app.Run();
