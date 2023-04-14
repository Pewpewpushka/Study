var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

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

//app.Use(async (context, next) =>
//{
//    var endpoint = context.GetEndpoint();
//    var rulesEndpoint = (endpoint as RouteEndpoint).RoutePattern.RawText;
//    Console.WriteLine(endpoint);
//});
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}");
});
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "",
        pattern: "/IT/{controller=Home}/{action=Calculate}");
});
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
        name: "",
        pattern: "/ITT/{controller=Home}/{action=Index}");
});

