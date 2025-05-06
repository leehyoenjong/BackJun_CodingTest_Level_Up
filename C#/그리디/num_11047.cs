/*
1. 아이디어
- 동전을 저장한, 순서를 뒤집음
- 동전을 for하며 동전 사용 갯수 추가, 동전 사용한 만큼 K값 갱신

2. 시간복잡도
- O(N)

3. 자료구조
- 동전 금액 : int[]
- 동전 사용 : int
- 남은 금액 : int

*/


class num_11047
{
    static void Mains(string[] args)
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = sr.ReadLine().Split();
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);


        List<int> coins = new List<int>();
        for (int i = 0; i < N; i++)
        {
            coins.Add(Convert.ToInt32(sr.ReadLine()));
        }

        coins.Reverse();
        int cnt = 0;
        for (int i = 0; i < coins.Count; i++)
        {
            cnt += K / coins[i];
            K = K % coins[i];
        }

        sw.WriteLine(cnt);
        sw.Flush();
        sw.Close();
        sr.Close();
    }
}