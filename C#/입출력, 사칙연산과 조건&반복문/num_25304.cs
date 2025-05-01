public class num_25304
{
    public void Main()
    {
        int total = Convert.ToInt32(Console.ReadLine());
        int max = Convert.ToInt32(Console.ReadLine());

        int price_total = 0;
        for (int i = 0; i < max; i++)
        {
            string[] input = Console.ReadLine().Split();
            int item = int.Parse(input[0]);
            int item_count = int.Parse(input[1]);

            price_total += item * item_count;
        }

        Console.WriteLine(total.CompareTo(price_total) == 0 ? "Yes" : "No");
    }
}