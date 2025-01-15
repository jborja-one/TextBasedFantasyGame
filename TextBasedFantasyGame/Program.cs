using System.Data;
using MySql.Data.MySqlClient;
using TextBasedFantasyGame.Repositories;
using TextBasedFantasyGame.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

// Add framework services
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add application builder.Services
builder.Services.AddSingleton<JobService>();
builder.Services.AddScoped<CharacterRepository>();
builder.Services.AddScoped<PlayerRepository>();
builder.Services.AddScoped<UserRepository>();

// Add database connection
builder.Services.AddScoped<IDbConnection>((s) =>
{
    IDbConnection conn = new MySqlConnection(builder.Configuration.GetConnectionString("DefaultConnection"));
    conn.Open();
    return conn;
});

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", builder =>
    {
        builder.AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
    });
});

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    // Enable Swagger in development
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    // Use HSTS in production
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseCors("AllowAll");

// app.MapControllerRoute(
//     name: "default",
//     pattern: "api/{controller}/{action=Index}/{id?}");
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers(); // This enables controller-based routings
});

app.MapFallbackToFile("index.html");

app.Run();

