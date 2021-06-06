using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

var app = WebApplication.Create(args);
app.MapGet("/", async http => { await http.Response.WriteAsync("Hello World!"); });
app.MapGet("/plant", async http => { await http.Response.WriteAsJsonAsync(new { Plant ="cactus"}); });
await app.RunAsync();