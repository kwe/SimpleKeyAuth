using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

var app = builder.Build();

app.MapGet("/", ( [FromHeader(Name = "simplekey")] string ? key) =>
{
    if (key == "letmein")
    {
        return Results.Ok("Hey!");
    }
    else
    {
        return Results.StatusCode(401);
    }
});

app.Run();