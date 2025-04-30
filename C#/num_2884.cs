public class num_2884
{
    public void Main()
    {
        string[] input = Console.ReadLine().Split();

        int hour = int.Parse(input[0]);
        int min = int.Parse(input[1]);

        min -= 45;

        if (min <= -1)
        {
            min += 60;
            hour--;

            if (hour <= -1)
            {
                hour = 23;
            }
        }

        Console.WriteLine($"{hour} {min}");
    }
}