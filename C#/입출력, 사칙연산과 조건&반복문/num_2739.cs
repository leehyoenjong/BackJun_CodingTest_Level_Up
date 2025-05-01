public class num_2739
{
    public void Main()
    {
        var value = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine($"{value} * {i} = {value * i}");
        }
    }
}