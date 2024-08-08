namespace CypherCharGen.Models;

public class Focus
{
    public int Id { set; get; }
    public string Name { set; get; }
    public int Might { set; get; }
    public int Speed { set; get; }
    public int Intellect { set; get; }

    // Add these once the other models are created
    //List<> Powers { set; get; }
    //List<> Abilities { set; get; }
    //List<> Equipment { set; get; }
    public string Page { set; get; }
    public string Description { set; get; }
}
