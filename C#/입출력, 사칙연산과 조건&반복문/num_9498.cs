public class num_9498
{
    public void mains()
    {
        int value1 = Convert.ToInt32(Console.ReadLine());

        if (100 >= value1 && value1 >= 90)
        {
            Console.WriteLine("A");
        }
        else if (89 >= value1 && value1 >= 80)
        {
            Console.WriteLine("B");
        }
        else if (79 >= value1 && value1 >= 70)
        {
            Console.WriteLine("C");
        }
        else if (69 >= value1 && value1 >= 60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }
}