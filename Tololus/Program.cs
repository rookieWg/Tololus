using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tololus.Data;




var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
//builder.Services.AddReCaptcha(builder.Configuration.GetSection("ReCaptcha"));
builder.Services.AddDbContext<ComingSoonContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ComingSoonContext") ?? throw new InvalidOperationException("Connection string 'ComingSoonContext' not found.")));




builder.Services.AddDbContext<TololusContext>(options =>




    options.UseSqlServer(builder.Configuration.GetConnectionString("TololusContext") ?? throw new InvalidOperationException("Connection string 'TololusContext' not found.")));
var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/404");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();

}



app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseStatusCodePagesWithRedirects("/errors/{0}");

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();


app.Run();
