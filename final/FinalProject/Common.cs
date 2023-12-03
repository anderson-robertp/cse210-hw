public class Common : Treasure{
    // Attributes
    private List<(LootItem item, int weight)> _common = new List<(LootItem item, int weight)>();

    //Constructor

    //Methods
    public override void Roll()
    {
        base.Roll();
    }
}