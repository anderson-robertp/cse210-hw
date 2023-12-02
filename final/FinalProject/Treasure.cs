public class Treasure{
    // Attributes
    protected List<(LootItem item, int weight)> _treasure = new List<(LootItem item, int weight)>();

    //Constructor

    //Methods
    public virtual void AddItem(LootItem item, int weight){
        _treasure.Add((item,weight));
    }
}