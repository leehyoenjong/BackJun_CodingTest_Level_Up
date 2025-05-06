class num_24265
{
    void mains()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine((long)n * (n - 1) / 2);
        Console.WriteLine(2);
    }

    /*
    MenOfPassion(A[], n) {
        sum <- 0;
        for i <- 1 to n - 1
            for j <- i + 1 to n
                sum <- sum + A[i] × A[j]; # 코드1
        return sum;
    }

    알고리즘 이해
    - 이중 반복문으로 알고리즘 수행 시간이 최고다항은 2이며
    - for문에 n-1이기 때문에 n * (n-1) / 2 처리, 
    - "첫째 줄에 입력의 크기 n(1 ≤ n ≤ 500,000)이 주어진다."이기 때문에 500,000 * 499,999 / 2 = 124,999,750,000로 int값인 21억을 넘겨 long타입으로 처리
    Console.WriteLine(n * (n - 1) / 2);
    Console.WriteLine(2);
    로 하면 끝
    */
}