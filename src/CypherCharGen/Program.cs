using CypherCharGen;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Initialize static test data
TypesCollection.Init();


// Hello World endpoint
//app.MapGet("/", () => "Hello World!");

// New endpoints
app.MapGet("/Types", () =>
{
    return TypesCollection.Types;
});

app.Run();
