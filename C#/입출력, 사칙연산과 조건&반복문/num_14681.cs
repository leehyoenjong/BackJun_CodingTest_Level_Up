public class num_14681
{
    public void mains()
    {
        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        if (x > 0)
        {
            if (y > 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("4");
            }
        }
        else
        {
            if (y > 0)
            {
                Console.WriteLine("2");
            }
            else
            {
                Console.WriteLine("3");
            }
        }
    }
}