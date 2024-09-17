namespace _9._16_hm1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Purchases list = new Purchases();
            list.Add("notebook");
            list.Add("pen");
            list.Add("pencil");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
