using System.Text;

public class num_11021
{
    public void mains()
    {
        int max = Convert.ToInt32(Console.ReadLine());
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < max; i++)
        {
            string[] input = Console.ReadLine().Split();
            int value1 = int.Parse(input[0]);
            int value2 = int.Parse(input[1]);

            result.AppendFormat("Case #{0}: {1}\n", i + 1, value1 + value2);
        }
        Console.WriteLine(result.ToString());
    }
}