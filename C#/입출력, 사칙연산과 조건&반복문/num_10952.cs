using System.Text;

public class num_10952
{
    public void Main()
    {
        StringBuilder result = new StringBuilder();
        while (true)
        {
            string[] input = Console.ReadLine().Split();
            int value1 = int.Parse(input[0]);
            int value2 = int.Parse(input[1]);

            if (value1 == 0 && value2 == 0)
            {
                break;
            }
            result.AppendFormat("{0}\n", value1 + value2);
        }
        Console.WriteLine(result.ToString());
    }
}