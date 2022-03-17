var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
    }
    /*
    //First Middleware
    app.Use(async(context, next) =>
    {
        await context.Response.WriteAsync("Hi All!!!");
        await next();                                           //call the next Middleware Execution
    });
//Second middleware
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync(" \nGooddy ! Malar");
    await next();
});*/
app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    app.Run();

