using System.Collections;

namespace _9._16_hm1;

public class PurchaseIterator : IEnumerator<string>
{
    Purchase iterator;
    Purchases purchases;
    public PurchaseIterator( Purchases purchases)
    {
        this.purchases = purchases;
    }
    public string Current => iterator.name;

    object IEnumerator.Current => Current;

    public void Dispose()
    {
    }

    public bool MoveNext()
    {
        if (iterator != null)
        {
            iterator = iterator.next;
            
        }
        else
        {
            iterator = purchases.head;
        }
        return iterator is not null;
    }

    public void Reset() => iterator = null;
}
