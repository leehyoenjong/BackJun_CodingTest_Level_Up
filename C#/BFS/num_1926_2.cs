class num_1926_2
{
    static void Main(string[] args)
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = sr.ReadLine().Split();
        int n = int.Parse(input[0]);
        int m = int.Parse(input[1]);


    }

    static int Bfs(int y, int x, int[][] map, int[][] chk, int n, int m)
    {
        int rs = 1;
        Queue<(int,int)> q = new Queue<(int,int)>();
        q.Enqueue((y,x));

        while(q.Count > 0)
        {
            var data = q.Dequene();
        }
    }
}