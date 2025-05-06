/*
1. 아이디어
- 투포인터 활용
- for문으로, 처음 k개값 저장
- 다음 인덱스 더하고, 이전 인덱스 빼줌
- 이때마다 최대값 갱신

2. 시간복잡도
- O(N) => 1e5 > 가능 

3. 자료구조
- 각 숫자들 N개 저장 배열 : int[] (숫자들 최대 100 > INT가능)
- K개의 값을 저장 변수 : int (최대 : K * 100 = 1e5 * 100 > INT가능)
- 최대값 : int
*/


public class num_2559
{
    static void Mains(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);

        string[] input_ = Console.ReadLine().Split();
        int[] nums = Array.ConvertAll(input_, int.Parse);

        //k개 더해주기
        int each = 0;
        for (int i = 0; i < K; i++)
        {
            each += nums[i];
        }
        //each가 없다면 매번 새로운 k개의 합을 구할때마다 k번의 덧셈하는 연산 필요
        //즉, O(N)이 아닌 O(K*N)이 되버림
        int maxv = each;

        // 다음인덱스 더해주고, 이전인덱스 빼주기
        for (int i = K; i < N; i++)
        {
            each += nums[i];
            each -= nums[i - K];
            maxv = Math.Max(maxv, each);
        }

        Console.WriteLine(maxv);
    }
}