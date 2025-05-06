public class num_11382
{
    public void mains()
    {
        string[] inputs = Console.ReadLine().Split();
        
        long value1 = long.Parse(inputs[0]);
        long value2 = long.Parse(inputs[1]);
        long value3 = long.Parse(inputs[2]);

        long result = value1 + value2 + value3;
        Console.WriteLine(result);
    }
}