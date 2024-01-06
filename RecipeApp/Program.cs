using Microsoft.EntityFrameworkCore;
using RecipeApp.Data;
using RecipeApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddDbContext<RecipeContext>(options => 
    options.UseSqlite("Data Source=RecipeDb.db"));
builder.Services.AddScoped<RecipeService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseHsts();
}
// app.UseExceptionHandler("/Error");
// app.UseStatusCodePagesWithReExecute("/Error/{0}");
// app.UseHsts();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.MapRazorPages();


app.Run();
