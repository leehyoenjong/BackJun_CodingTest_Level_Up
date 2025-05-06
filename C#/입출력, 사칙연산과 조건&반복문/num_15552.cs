using System.Text;

public class num_15552
{
    public void mains()
    {
        var max = Convert.ToInt32(Console.ReadLine());
        StringBuilder stringBuilder = new StringBuilder();
        for (int i = 0; i < max; i++)
        {
            string[] input = Console.ReadLine().Split();

            int value1 = int.Parse(input[0]);
            int value2 = int.Parse(input[1]);

            stringBuilder.Append(value1 + value2);
            if (i < max - 1)
            {
                stringBuilder.Append("\n");
            }
        }
        Console.WriteLine(stringBuilder.ToString());
    }
}