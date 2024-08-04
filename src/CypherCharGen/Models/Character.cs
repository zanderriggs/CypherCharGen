namespace CypherCharGen.Models
{
    public class Character
    {
        string Name { get; set; }
        Descriptor Descriptor { get; set; }
        Type Type { get; set; }
        Focus Focus { get; set; }
    }

    
}
