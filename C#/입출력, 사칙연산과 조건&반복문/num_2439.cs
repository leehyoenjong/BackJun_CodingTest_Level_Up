using System.Text;

public class num_2439
{
    public void mains()
    {
        int max = Convert.ToInt32(Console.ReadLine());

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < max; i++)
        {
            for (int x = 0; x < max - i - 1; x++)
            {
                result.Append(" ");
            }
            for (int x = 0; x < i + 1; x++)
            {
                result.Append("*");
            }
            result.Append("\n");
        }
        Console.WriteLine(result.ToString());
    }
}