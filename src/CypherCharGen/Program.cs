using CypherCharGen;
using CypherCharGen.Models;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Initialize static test data
TypesCollection.Init();


// Hello World endpoint
//app.MapGet("/", () => "Hello World!");

// Get all character types
app.MapGet("/Types", () =>
{
    return TypesCollection.Types;
});

// Get single character type
app.MapGet("/Types/{id}", (HttpRequest request) =>
{
    if (request.RouteValues["id"] is not  null)
    {
        var typeId = int.Parse(request.RouteValues?["id"].ToString() ?? "0");
        var typeToReturn = TypesCollection.Types.FirstOrDefault(x => x.Id == typeId);
        return typeToReturn;
    }
    return null;
});

// Create new character type
app.MapPost("/Types", (CharacterType newCharacterType) =>
{
    TypesCollection.addNewCharacterType(newCharacterType);
    return Results.Ok();
});

// Update character type
app.MapPut("/Types", (CharacterType characterTypeToUpdate) =>
{
    try
    {
        TypesCollection.UpdateCharacterType(characterTypeToUpdate);
        return Results.Ok();
    }
    catch (Exception ex)
    {
        return Results.Problem(ex.Message);
    }
});

// Delete character type
app.MapDelete("/Types/{id}", (HttpRequest request) =>
{
    var id = int.Parse(request.RouteValues?["id"].ToString() ?? "0");
    var typeToDelete = TypesCollection.Types.FirstOrDefault(x => x.Id == id);

    if (typeToDelete is not null)
    {
        TypesCollection.Types.Remove(typeToDelete);
        return Results.Ok(); ;
    }
    else
    {
        return Results.Problem("Character type to delete not found.");
    }
});

app.Run();
