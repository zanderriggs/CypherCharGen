﻿using CypherCharGen.Models;

namespace CypherCharGen;

public static class TypesCollection
{
    public static List<CharacterType> Types = [];

    public static void Init()
    {
        Types.Add(new CharacterType()
        {
            Id = 1,
            Name = "Type Name",
            Might = 1,
            Speed = 2,
            Intellect = 3,
            MightEdge = 1,
            SpeedEdge = 1,
            IntellectEdge = 1,
            Effort = 1,
            Shins = 10,
            Page = "page number 5",
            Description = "Character Type Description"
        });

        Types.Add(new CharacterType()
        {
            Id = 2,
            Name = "Second Type Name",
            Might = 3,
            Speed = 2,
            Intellect = 1,
            MightEdge = 2,
            SpeedEdge = 2,
            IntellectEdge = 2,
            Effort = 2,
            Shins = 10,
            Page = "page number 10",
            Description = "Character Type Description"
        });

        Types.Add(new CharacterType()
        {
            Id = 3,
            Name = "Type Name",
            Might = 2,
            Speed = 1,
            Intellect = 3,
            MightEdge = 1,
            SpeedEdge = 1,
            IntellectEdge = 1,
            Effort = 1,
            Shins = 10,
            Page = "page number",
            Description = "Character Type Description"
        });
    }

    public static void AddNewCharacterType(CharacterType charactertype)
    {
        var latestId = Types.Max(x => x.Id);
        Types.Add(new CharacterType()
        {
            Id = latestId + 1,
            Name = charactertype.Name,
            Might = charactertype.Might,
            Speed = charactertype.Speed,
            Intellect = charactertype.Intellect,
            MightEdge = charactertype.MightEdge,
            SpeedEdge = charactertype.SpeedEdge,
            IntellectEdge = charactertype.IntellectEdge,
            Effort = charactertype.Effort,
            Shins = charactertype.Shins,
            Page = charactertype.Page,
            Description = charactertype.Description,
        });
    }

    public static void UpdateCharacterType(CharacterType charactertype)
    {
        var typeToUpdate = Types.FirstOrDefault(x => x.Id == charactertype.Id);

        if (typeToUpdate is not null)
        {
            typeToUpdate.Name = charactertype.Name;
            typeToUpdate.Might = charactertype.Might;
            typeToUpdate.Speed = charactertype.Speed;
            typeToUpdate.Intellect = charactertype.Intellect;
            typeToUpdate.MightEdge = charactertype.MightEdge;
            typeToUpdate.SpeedEdge = charactertype.SpeedEdge;
            typeToUpdate.IntellectEdge = charactertype.IntellectEdge;
            typeToUpdate.Effort = charactertype.Effort;
            typeToUpdate.Shins = charactertype.Shins;
            typeToUpdate.Page = charactertype.Page;
            typeToUpdate.Description = charactertype.Description;
        }
        else
        {
            throw new Exception("Type not found.");
        }

    }
}
