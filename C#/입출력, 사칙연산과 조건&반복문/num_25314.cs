using System.Text;

public class num_25314
{
    public void Main()
    {
        var input = Convert.ToInt32(Console.ReadLine());

        var total = input / 4;
        StringBuilder stringBuilder = new StringBuilder();

        for (int i = 0; i < total; i++)
        {
            stringBuilder.Append("long ");
        }
        stringBuilder.Append("int");

        Console.WriteLine(stringBuilder.ToString());
    }
}