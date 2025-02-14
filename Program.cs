var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Enable serving static files from wwwroot
app.UseStaticFiles();

// Redirect the root URL `/` to serve `index.html`
app.MapGet("/", (HttpContext context) =>
{
    context.Response.Redirect("/index.html");
});

app.Run();