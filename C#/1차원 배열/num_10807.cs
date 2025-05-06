public class num_10807
{
    public void mains()
    {
        int max = Convert.ToInt32(Console.ReadLine());
        string[] input = Console.ReadLine().Split();
        int check_value = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[max];

        int v = 0;
        for (int i = 0; i < input.Length; i++)
        {
            int result = int.Parse(input[i]);
            arr[i] = result;

            if (check_value == result)
            {
                v++;
            }
        }

        Console.WriteLine(v);
    }
}