
var builder = WebApplication.CreateBuilder(args);
//Configure services
builder.Services.AddControllersWithViews();

var app = builder.Build();

//Configure middleware
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
