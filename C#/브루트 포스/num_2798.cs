class num_2798
{
    void Main()
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int M = int.Parse(input[1]);

        string[] input2 = Console.ReadLine().Split();

        List<int> list = new List<int>();
        for (int i = 0; i < N; i++)
        {
            var value = int.Parse(input2[i]);
            list.Add(value);
        }

        int result = 0;
        for (int i = 0; i < N - 2; i++)
        {
            for (int j = i + 1; j < N - 1; j++)
            {
                for (int k = j + 1; k < N; k++)
                {
                    int sum = list[i] + list[j] + list[k];
                    if (sum <= M && sum > result)
                    {
                        result = sum;
                    }
                }
            }
        }
        Console.WriteLine(result);
    }

    /*
    알고리즘 이해
    - 브루트 포스는 완전 탐색으로 모든 조합을 확인하기 위해 3중 반복문을 이용하여 조합을 찾아 출력
    */
}