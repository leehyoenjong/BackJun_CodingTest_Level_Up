using System.Text;

public class num_10871
{
    public void mains()
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int X = int.Parse(input[1]);

        string[] A = Console.ReadLine().Split();
        int[] arr = new int[N];

        StringBuilder result = new StringBuilder();
        for (int i = 0; i < N; i++)
        {
            int value = int.Parse(A[i]);
            arr[i] = value;

            if(value < X)
            {
                result.AppendFormat("{0} ",value);
            }
        }

        Console.WriteLine(result.ToString());
    }
}