using System;
using System.Text;

public class num_10951
{
    public void Main()
    {
        StringBuilder result = new StringBuilder();

        while (true)
        {
            // EOF까지 계속 입력 받기
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input) || input == null)
            {
                break;
            }
            string[] values = input.Split();
            int value1 = int.Parse(values[0]);
            int value2 = int.Parse(values[1]);

            result.AppendLine((value1 + value2).ToString());
        }

        Console.Write(result.ToString());
    }
}