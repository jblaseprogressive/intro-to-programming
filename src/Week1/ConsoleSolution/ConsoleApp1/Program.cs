var builder = WebApplication.CreateBuilder(args);

string message = "Welcome to Class";

DateTime now = DateTime.Now;

string finalMessage = "$The Message {message} and it is now {now:T}";

var app = builder.Build();

app.MapGet("/message", () =>
{
    var response = new MessageResponseModel("This is an API! Wow!", DateTime.Now);
    return Results.Ok(finalMessage);
});

app.Run();

public record MessageResponseModel(string Message, DateTime When);