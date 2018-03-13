public abstract class Machine
{
    public string Id { get; private set; }
    public abstract string Type { get; }
    protected Machine(string id)
    {
        this.Id = id;
    }
}

