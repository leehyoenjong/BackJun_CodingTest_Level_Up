public class num_10950
{
    public void mains()
    {
        int max = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < max; i++)
        {
            var input = Console.ReadLine().Split();
            var value1 = int.Parse(input[0]);
            var value2 = int.Parse(input[1]);
            Console.WriteLine($"{value1 + value2}");
        }
    }
}