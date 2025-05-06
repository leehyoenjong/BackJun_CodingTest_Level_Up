/*
1. 아이디어
- 한점 시작, 모든거리: 다익스트라
- 간선, 인접리스트 저장
- 거리배열 무한대 초기화
- 시작점 : 거리배열 0, 힙에 넣어주기
- 힙에서 빼며 다음 것을 수행
    -> 최신값인지 먼저 확인
    -> 간선을 타고 간 비용이 더 작으면 갱신

2. 시간복잡도
- 다익스트라 : O(ElgV)
    -> E : 3e5
    -> V : 2e4, lgV ~= 20
    -> ElgV = 6e6

3. 변수
- 힙 : (비용, 노드번호)
- 거리 배열(비용) : int[]
- 간선 저장, 인접리스트 : (비용, 노드번호)[]

*/

class num_1753
{
    static void Mains(string[] args)
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = sr.ReadLine().Split();
        //정점 개수
        int V = int.Parse(input[0]);
        //간선 개수
        int E = int.Parse(input[1]);
        //시작점
        int K = Convert.ToInt32(sr.ReadLine());

        //노드별 비용과 간선수 리스트
        var edge = new List<List<Tuple<int, int>>>();
        for (int i = 0; i <= V; i++)
        {
            edge.Add(new List<Tuple<int, int>>());
        }

        //최소값을 구하기 위한 값 배열, MaxValue로 초기화
        int[] dist = new int[V + 1];
        for (int i = 0; i <= V; i++)
        {
            dist[i] = int.MaxValue;
        }


        for (int i = 0; i < E; i++)
        {
            string[] input_ = sr.ReadLine().Split();
            //노드번호
            int u = int.Parse(input_[0]);
            //간선개수
            int v = int.Parse(input_[1]);
            //비용
            int w = int.Parse(input_[2]);

            edge[u].Add(new Tuple<int, int>(w, v));
        }

        PriorityQueue<int[], int> heap = new PriorityQueue<int[], int>();

        //시작점 초기화
        dist[K] = 0;
        //시작점이기 때문에 비용은 0 시작노드 K 로 초기화
        heap.Enqueue(new int[] { 0, K }, 0);


        while (heap.Count > 0)
        {
            var qdata = heap.Dequeue();
            int w = qdata[0];
            int node = qdata[1];

            //현재 node의 비용값이 다르면 힙 새로 가져오기
            if (dist[node] != w)
            {
                continue;
            }

            //
            foreach (var next in edge[node])
            {
                //다음 노드의 비용
                int nw = next.Item1;
                //다음 노드의 연결된 노드번호
                int nv = next.Item2;

                //다음노드의 비용이 가져온 노드의 비용과 다음 노드의 비용 비교 
                if (dist[nv] <= w + nw)
                {
                    continue;
                }
                dist[nv] = w + nw;
                //더 작다면 현재 노드의 비용과 노드 번호 힙에 추가
                heap.Enqueue(new int[] { dist[nv], nv }, dist[nv]);
            }
        }

        //출력
        for (int i = 1; i <= V; i++)
        {
            if (dist[i] == int.MaxValue)
            {
                sw.WriteLine("INF");
            }
            else
            {
                sw.WriteLine(dist[i]);
            }
        }

        sw.Flush();
        sw.Close();
        sr.Close();
    }
}