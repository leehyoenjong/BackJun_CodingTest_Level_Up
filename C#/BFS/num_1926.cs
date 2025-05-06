class num_1926
{
    static int[] dy = { 0, 1, 0, -1 };
    static int[] dx = { 1, 0, -1, 0 };

    static void Mains()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);

        int[][] map = new int[n][];
        bool[][] chk = new bool[n][];

        for (int i = 0; i < n; i++)
        {
            map[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            chk[i] = new bool[m];
        }

        int cnt = 0;
        int maxv = 0;

        for (int j = 0; j < n; j++)
        {
            for (int i = 0; i < m; i++)
            {
                if (map[j][i] == 1 && !chk[j][i])
                {
                    chk[j][i] = true;
                    cnt++;
                    maxv = Math.Max(maxv, Bfs(j, i, map, chk, n, m));
                }
            }
        }

        Console.WriteLine(cnt);
        Console.WriteLine(maxv);
    }

    static int Bfs(int y, int x, int[][] map, bool[][] chk, int n, int m)
    {
        int rs = 1;
        Queue<(int, int)> q = new Queue<(int, int)>();
        q.Enqueue((y, x));

        while (q.Count > 0)
        {
            (int ey, int ex) = q.Dequeue();

            for (int k = 0; k < 4; k++)
            {
                int ny = ey + dy[k];
                int nx = ex + dx[k];

                if (0 <= ny && ny < n && 0 <= nx && nx < m)
                {
                    if (map[ny][nx] == 1 && !chk[ny][nx])
                    {
                        rs++;
                        chk[ny][nx] = true;
                        q.Enqueue((ny, nx));
                    }
                }
            }
        }

        return rs;
    }
}