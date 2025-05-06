public class num_10818
{
    public void mains()
    {
        Arr();
        List();
    }
    static void Arr()
    {
        int N = Convert.ToInt32(Console.ReadLine());

        string[] input = Console.ReadLine().Split();
        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
        {
            var value = int.Parse(input[i]);
            arr[i] = value;
        }
        Console.WriteLine($"{arr.Min()} {arr.Max()}");
    }
    static void List()
    {
        int N = Convert.ToInt32(Console.ReadLine());

        string[] input = Console.ReadLine().Split();
        List<int> list = new List<int>();
        for (int i = 0; i < N; i++)
        {
            var value = int.Parse(input[i]);
            list.Add(value);
        }
        Console.WriteLine($"{list.Min()} {list.Max()}");
    }


}