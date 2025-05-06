/*
1. 아이디어
- MST 기본문제 외워서 풀 것
- 간선을 인접리스트에 집어넣기
- 힙에 시작점 넣기
- 힙이 비어질때까지 작업 반복
-> 힙 최소값 꺼내서, 노드 방문 여부 확인
-> 방문 안했다면 방문표시 및 비용 추가, 연결된 간선 힙에 넣기기

2. 시간복잡도
- MST : O(ElgE)

3. 자료구조
- 간선 저장되는 인접리스트 : (비용, 노드번호)
- 힙 : (비용, 노드번호)
- 방문 여부 : bool[]
- MST 결과값 : int
*/

class num_1197
{
    static void Mains(string[] args)
    {
        var sr = new StreamReader(Console.OpenStandardInput());
        var sw = new StreamWriter(Console.OpenStandardOutput());

        string[] input = sr.ReadLine().Split();
        int V = int.Parse(input[0]);
        int E = int.Parse(input[1]);

        //1부터 시작이라 +1
        bool[] chk = new bool[V + 1];

        //인접리스트 생성 <= 이유는 1부터 시작이기 때문에 <=로 진행
        var edge = new List<List<int[]>>();
        for (int i = 0; i <= V; i++)
        {
            edge.Add(new List<int[]>());
        }

        for (int i = 0; i < E; i++)
        {
            string[] input_ = sr.ReadLine().Split();
            int a = int.Parse(input_[0]);//노드번호
            int b = int.Parse(input_[1]);//노드번호
            int c = int.Parse(input_[2]);//비용

            edge[a].Add(new int[] { c, b });
            //양방향이기 때문에 a,b 두개를 넣어야함
            edge[b].Add(new int[] { c, a });
        }

        PriorityQueue<int[], int> heap = new PriorityQueue<int[], int>();

        // 시작 노드를 우선순위 큐에 추가 (비용 0, 노드 번호 1)
        heap.Enqueue(new int[] { 0, 1 }, 0);

        int result = 0;
        while (heap.Count > 0)
        {
            //값 뽑아서 체크
            var data = heap.Dequeue();
            int w = data[0];
            int each_node = data[1];

            //방문했는지 체크
            if (chk[each_node])
            {
                continue;
            }

            //방문표시
            chk[each_node] = true;

            //비용 추가
            result += w;

            //each_node의 간선들 체크
            foreach (var item in edge[each_node])
            {
                //노드에 방문 했는지 체크
                if (chk[item[1]])
                {
                    continue;
                }

                //간선 정보(비용, 다음 노드) 우선순위 큐에 추가
                heap.Enqueue(item, item[0]);
            }
        }

        sw.WriteLine(result);
        sw.Flush();
        sw.Close();
        sr.Close();
    }
}