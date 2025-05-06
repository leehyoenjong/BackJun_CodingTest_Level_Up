public class num_1330
{
    public void mains()
    {
        string[] input = Console.ReadLine().Split();

        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        if (A > B)
        {
            Console.WriteLine(">");
        }
        else if (A < B)
        {
            Console.WriteLine("<");
        }
        else if (A == B)
        {
            Console.WriteLine("==");
        }
    }
}
