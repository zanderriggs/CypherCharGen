namespace CypherCharGen.Models;

public class CharacterType
{
    public int Id { set; get; }
    public string Name { set; get; }
    public int Might { set; get; }
    public int Speed { set; get; }
    public int Intellect { set; get; }
    public int MightEdge { set; get; }
    public int SpeedEdge { set; get; }
    public int IntellectEdge { set; get; }
    public int Effort { set; get; }
    // Add these once the other models are created
    //List<> Traits { set; get; }
    //List<> Training { set; get; }
    //List<> Inability { set; get; }
    //List<> Equipment { set; get; }
    public int Shins { set; get; }
    public string Page { set; get; }
    public string Description { set; get; }
}
