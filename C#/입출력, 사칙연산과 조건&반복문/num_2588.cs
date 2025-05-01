public class num_2588
{
    public void Main()
    {
        int value1 = Convert.ToInt32(Console.ReadLine());
        int value2 = Convert.ToInt32(Console.ReadLine());

        string strvalue2 = value2.ToString();

        for (int i = strvalue2.Length - 1; i >= 0; i--)
        {
            int digit = Convert.ToInt32(strvalue2[i].ToString());
            Console.WriteLine(Convert.ToInt32(value1 * digit));
        }
        int result = value1 * value2;
        Console.WriteLine(Convert.ToInt32(result));
    }
}