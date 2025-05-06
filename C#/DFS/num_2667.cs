/*
1. 아이디어
- 2중 for, 값이 1&& 방문X => DFS
- DFS를 통해 찾은 값을 저장 후 출력
2. 시간 복잡도
- DFS : O(V+E)
- V, E : N^2, 4N^2
- V + E : 5N^2 ~= N^2 ~ = 625 >> 가능
3. 자료구조
- 그래프 저장 : int[][]
- 방문여부 : bool[][]
- 결과값 : int[]
*/

public class num_2667
{
    static int[] dy = { 0, 1, 0, -1 };
    static int[] dx = { 1, 0, -1, 0 };
    static int Each = 0;
    public static void Mains()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] arr = new int[n][];
        bool[][] chk = new bool[n][];

        List<int> result = new List<int>();

        for (int i = 0; i < n; i++)
        {
            string line = Console.ReadLine();
            arr[i] = new int[n];
            for (int j = 0; j < n; j++)
            {
                // 문자열을 한 글자씩 숫자로 변환
                arr[i][j] = line[j] - '0';
            }
            chk[i] = new bool[n];
        }

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (arr[i][j] == 1 && !chk[i][j])
                {
                    //방문 체크 표시
                    chk[i][j] = true;
                    //DFS로 크기 구하기
                    Each = 0;
                    Dfs(i, j, n, arr, chk);
                    //값 저장 
                    result.Add(Each);
                }
            }
        }

        result.Sort();
        Console.WriteLine(result.Count);
        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i]);
        }
    }

    static void Dfs(int i, int j, int n, int[][] arr, bool[][] chk)
    {
        Each++;
        for (int x = 0; x < 4; x++)
        {
            int ny = i + dy[x];
            int nx = j + dx[x];

            if (0 <= ny && ny < n && 0 <= nx && nx < n)
            {
                if (arr[ny][nx] == 1 && !chk[ny][nx])
                {
                    chk[ny][nx] = true;
                    Dfs(ny, nx, n, arr, chk);
                }
            }
        }
    }
}