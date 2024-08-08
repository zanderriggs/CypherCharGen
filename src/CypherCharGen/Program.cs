using CypherCharGen;
using CypherCharGen.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddDbContext<CharacterTypeDb>(options => options.UseInMemoryDatabase("items"));
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Cypher System Generator",
        Description = "Making characters in the ",
        Version = "v1"
    });
});

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "PizzaStore API V1");
    });
}

// Initialize static test data
TypesCollection.Init();

// Get all character types
app.MapGet("/type", async (CharacterTypeDb db) => await db.CharacterTypes.ToListAsync());

// Get single character type
app.MapGet("/type/{id}", async(CharacterTypeDb db, int id) => await db.CharacterTypes.FindAsync(id));

// Create new character type
app.MapPost("/type", async (CharacterTypeDb db, CharacterType newCharacterType) =>
{
    await db.CharacterTypes.AddAsync(newCharacterType);
    await db.SaveChangesAsync();
    return Results.Created($"/type/{newCharacterType.Id}", newCharacterType);
});

// Update character type
app.MapPut("/type/{id}", async (CharacterTypeDb db, CharacterType characterTypeToUpdate, int id) =>
{
    var characterType = await db.CharacterTypes.FindAsync(id);
    if (characterType is null)
    {
        return Results.NotFound();
    }

    db.Entry(characterType).CurrentValues.SetValues(characterTypeToUpdate);

    await db.SaveChangesAsync();
    return Results.Ok();
});

// Delete character type
app.MapDelete("/type/{id}", async (CharacterTypeDb db, int id) =>
{
    var characterType = await db.CharacterTypes.FindAsync(id);
    if (characterType is null)
    {
        return Results.NotFound();
    }

    db.CharacterTypes.Remove(characterType);
    await db.SaveChangesAsync();
    return Results.Ok();
});

app.Run();
