namespace BoxUnbox;
class Program
{
    static void Main(string[] args)
    {
        List<Object> list = new List<object> { 7, 28, -1, true, "chair" };

        int accumulador = 0;
        foreach (var item in list)
        {
            Console.WriteLine(item);
            if (item is int)
            {
                accumulador += (int)item;
            }
        }
        Console.WriteLine($"resultado: {accumulador}");

    }
}
