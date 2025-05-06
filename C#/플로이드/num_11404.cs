/*
1. 아이디어
- 모든 점 -> 모든 점 : 플로이드 사용
- 비용 배열 INF 초기화
- 간선 비용 대입
- 거쳐갈때 비용이 작을 경우, 갱신(for문 3번)

2. 시간복잡도
- 플로이드 : O(V^3)

3. 변수
- 비용 배열, int[][]
*/


class num_11404
{
    static void Mains(string[] args)
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        int n = Convert.ToInt32(sr.ReadLine());
        int m = Convert.ToInt32(sr.ReadLine());

        //플로이드는 모든 행의 크기가 동일하기 때문에 다차원 배열 사용 
        int[,] rs = new int[n + 1, n + 1];

        
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j <= n; j++)
            {
                //자신의 시작점은 0으로 초기화
                if (i == j)
                {
                    rs[i, j] = 0;
                }
                //아니면 전부 최대값 
                else
                {
                    rs[i, j] = int.MaxValue;
                }
            }
        }

        for (int i = 0; i < m; i++)
        {
            string[] input = sr.ReadLine().Split();
            int a = int.Parse(input[0]);
            int b = int.Parse(input[1]);
            int c = int.Parse(input[2]);

            //더 작은 것으로 삽입
            rs[a, b] = Math.Min(rs[a, b], c);
        }

        for (int i = 1; i <= n; i++)//거치는 값
        {
            for (int j = 1; j <= n; j++)//시작
            {
                for (int k = 1; k <= n; k++)//도착
                {
                    //최대값이 이면 넘기기
                    if (rs[j, i] == int.MaxValue || rs[i, k] == int.MaxValue)
                    {
                        continue;
                    }

                    //시작 -> 도착 하는 값이 : 시작 -> 거치는 값 + 도착 -> 거치는 값 보다 작으면
                    if (rs[j, k] > rs[j, i] + rs[i, k])
                    {
                        //값 갱신 
                        rs[j, k] = rs[j, i] + rs[i, k];
                    }
                }
            }
        }


        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                //최대값이면 0으로 표기해돌라 했기 때문에 0으로 표기
                if (rs[i, j] == int.MaxValue)
                {
                    sw.Write("0 ");
                }
                else
                {
                    sw.Write($"{rs[i, j]} ");
                }
            }
            sw.WriteLine();
        }

        sw.Flush();
        sw.Close();
        sr.Close();
    }
}