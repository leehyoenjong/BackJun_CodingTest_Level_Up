class num_24313
{
    void mains()
    {
        string[] input = Console.ReadLine().Split();
        int a1 = int.Parse(input[0]);
        int a0 = int.Parse(input[1]);
        int c = Convert.ToInt32(Console.ReadLine());
        int n0 = Convert.ToInt32(Console.ReadLine());

        bool check1 = a1 <= c;
        bool check2 = a1 * n0 + a0 <= c * n0;

        Console.WriteLine(check1 && check2 ? 1 : 0);
    }

    /*
    알고리즘 이해
    - f(n) = 7n + 7, g(n) = n, c = 8, n0 = 10 이라고 한다
    - n0는 n의 최소값이며, n0를 n으로 계산했을때 만족하면 그 이상의 값은 모두가 만족한다.
    - 그래서 계산식이 a1 * n0 + a0 <= c *n0이게 된다.
    */
}