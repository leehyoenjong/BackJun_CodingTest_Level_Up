public class num_8393
{
    public void Main()
    {
        int value = Convert.ToInt32(Console.ReadLine());
        int max = value;
        for (int i = 1; i < max; i++)
        {
            value += i;
        }
        Console.WriteLine(value);
    }
}