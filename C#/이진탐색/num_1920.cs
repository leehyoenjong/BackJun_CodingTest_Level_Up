/*
1. 아이디어
- N개의 숫자 정렬
- M개를 for 돌며, 이진탐색 수행
- 이진탐색 안에서 마지막 데이터 찾으면, 1출력 아니면 0출력

2. 시간 복잡도
- N개의 입력값 정렬 = O(NlgN)
- M개를 N개중에서 탐색 = O(M * lgN)
- 총합 : O((N+M)lgN)

3. 자료구조
- N개의 숫자 int[]
- M개의 숫자 int[]
*/

class num_1920
{
    static void Mains(string[] args)
    {
        // 빠른 입출력을 위한 설정
        var sr = new System.IO.StreamReader(Console.OpenStandardInput());
        var sw = new System.IO.StreamWriter(Console.OpenStandardOutput());

        int n = Convert.ToInt32(sr.ReadLine());
        List<int> nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse).ToList();

        int m = Convert.ToInt32(sr.ReadLine());
        List<int> target_nums = Array.ConvertAll(sr.ReadLine().Split(), int.Parse).ToList();


        //정렬해야 이진탐색 가능
        nums.Sort();

        for (int i = 0; i < target_nums.Count; i++)
        {
            sw.WriteLine(Search(0, n - 1, target_nums[i], nums));
        }

        sw.Flush();
        sr.Close();
        sw.Close();
    }

    public static int Search(int start, int end, int target, List<int> nums)
    {
        if (start == end)
        {
            return nums[start] == target ? 1 : 0;
        }

        int mid = (start + end) / 2;

        if (nums[mid] < target)
        {
            return Search(mid + 1, end, target, nums);
        }
        else
        {
            return Search(start, mid, target, nums);
        }
    }
}