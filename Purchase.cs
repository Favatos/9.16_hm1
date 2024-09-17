namespace _9._16_hm1;

public class Purchase
{
    public string name;
    public Purchase next { get; set;  }
    public Purchase(string name)
    {
        this.name = name;
    }
}
