using System.Text;

public class num_2438
{
    public void Main()
    {
        int max = Convert.ToInt32(Console.ReadLine());

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < max; i++)
        {
            for (int x = 0; x < i + 1; x++)
            {
                result.Append("*");
            }
            result.Append("\n");
        }
        Console.WriteLine(result.ToString());
    }
}