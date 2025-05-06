/*
1. 아이디어
- 백트래킹 재귀함수 안에서, for 돌면서 숫자 선택(이때 방문 여부 확인)
- 재귀함수에서 m개를 선택할 경우 출력

2. 시간복잡도
- N! 

3. 자료구조
- 결과값 저장 int[]
- 방문여부 bool[]
*/


public class num_15649
{
    static int N, M;
    static List<int> rs = new List<int>();
    static bool[] chk;

    static void Mains(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        N = int.Parse(input[0]);
        M = int.Parse(input[1]);

        chk = new bool[N + 1];

        Recur(0);
    }

    static void Recur(int num)
    {
        if (num == M)
        {
            Console.WriteLine(string.Join(" ", rs));
            return;
        }

        for (int i = 1; i <= N; i++)
        {
            if (chk[i] == false)
            {
                chk[i] = true;
                rs.Add(i);
                Recur(num + 1);
                chk[i] = false;
                rs.RemoveAt(rs.Count - 1);
            }
        }
    }
}