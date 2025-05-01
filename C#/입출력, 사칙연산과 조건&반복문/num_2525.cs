public class num_2525
{
    public void Main()
    {
        string[] input_1 = Console.ReadLine().Split();

        int hour = int.Parse(input_1[0]);
        int min = int.Parse(input_1[1]);
        int oventime = Convert.ToInt32(Console.ReadLine());

        min += oventime;
        int min_result = min / 60;
        min -= 60 * min_result;

        hour += min_result;
        int hour_result = hour / 24;
        hour -= 24 * hour_result;
        Console.WriteLine($"{hour} {min}");
    }
}