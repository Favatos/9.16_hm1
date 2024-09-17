using System.Collections;

namespace _9._16_hm1;

public class Purchases : IEnumerable<string>
{
    public Purchase head { get; set; }
    Purchase tail;
    int count;
    
    public void Add(string name)
    {
        Purchase purchase = new Purchase(name);
        if (head == null)
        {
            head = purchase;
        }
        else
        {
            tail!.next = purchase;
        }
        tail = purchase;
        count++;
    }
    public int Count() => count;
    public IEnumerator<string> GetEnumerator()
    {
        return new PurchaseIterator(this);
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    
}
