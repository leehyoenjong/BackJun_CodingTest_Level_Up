/*
1. 아이디어
- 점화식 : An = An-1 + An-2
- N값을 구하기 위해 for문으로 3부터 N까지 값을 구해주기
- 이전값, 그 그이전값을 더해, 10007로 나눠 저장

2. 시간복잡도
- O(N)

3. 자료구조
- DP값 저장용(경우의 수) : int[]
*/


class num_11726
{
    static void Mains(string[] args)
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = Convert.ToInt32(sr.ReadLine());

        List<int> result = new List<int>() { 0, 1, 2 };
        for (int i = 3; i < n + 1; i++)
        {
            result.Add((result[i - 1] + result[i - 2]) % 10007);
        }

        sw.WriteLine(result[n]);
        sw.Flush();
        sw.Close();
        sr.Close();
    }
}