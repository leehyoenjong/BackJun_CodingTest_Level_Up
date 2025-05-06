public class num_2753
{
    public void mains()
    {
        int year = Convert.ToInt32(Console.ReadLine());

        int result_4 = year % 4;
        int result_100 = year % 100;
        int result_400 = year % 400;

        if (result_4 == 0 && (result_100 != 0 || result_400 == 0))
        {
            Console.WriteLine("1");
        }
        else
        {
            Console.WriteLine("0");
        }
    }
}