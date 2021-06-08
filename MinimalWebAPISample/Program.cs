using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;

string[] Summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

var rng = new Random();

var app = WebApplication.Create(args);
app.MapGet("/", async http => { await http.Response.WriteAsync("Hello World!"); });
app.MapGet("/plant", async http => { await http.Response.WriteAsJsonAsync(new { Name = "cactus" }); });
app.MapGet("/weatherforecast", async http =>
{
    await http.Response.WriteAsJsonAsync
    (
        Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = rng.Next(-20, 55),
            Summary = Summaries[rng.Next(Summaries.Length)]
        })
        .ToArray()
    );
});
await app.RunAsync();

public class WeatherForecast
{
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
    public string Summary { get; set; }
}