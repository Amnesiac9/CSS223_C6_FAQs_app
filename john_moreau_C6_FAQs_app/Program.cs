using Microsoft.EntityFrameworkCore;
using john_moreau_C6_FAQs_app.Models;
using Microsoft.AspNetCore.Routing.Constraints;

/*
* John Moreau
* CSS233
* 11/1/2023
*
*
*/

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRouting(options => {
    options.LowercaseUrls = true;
    options.AppendTrailingSlash = true;

});


// Add EF Core DI
builder.Services.AddDbContext<FAQContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("FAQContext")));

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




// Custom Routing to show topic and category in URL. Remove "?" to skip this route if they are null or empty.
app.MapControllerRoute(
    name: "both",
    pattern: "{controller=Home}/{action=Index}/topic/{topic}/category/{category}"
);

app.MapControllerRoute(
    name: "topic",
    pattern: "{controller=Home}/{action=Index}/topic/{topic}"
);

app.MapControllerRoute(
    name: "category",
    pattern: "{controller=Home}/{action=Index}/category/{category}"
);

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
);

app.Run();
