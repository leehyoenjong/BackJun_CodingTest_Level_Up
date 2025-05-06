class num_24266
{
    void mains()
    {
        long n = long.Parse(Console.ReadLine());

        long result = n * n * n;
        Console.WriteLine(result);
        Console.WriteLine(3);
    }

    /*
    MenOfPassion(A[], n) {
        sum <- 0;
        for i <- 1 to n
            for j <- 1 to n
                for k <- 1 to n
                    sum <- sum + A[i] × A[j] × A[k]; # 코드1
        return sum;
    }

    알고리즘 이해
    - 삼중 반복문으로 알고리즘 수행 시간이 최고다항은 3이며
    - "첫째 줄에 입력의 크기 n(1 ≤ n ≤ 500,000)이 주어진다."이기 때문에 500,000 * 499,999 / 2 = 124,999,750,000로 int값인 21억을 넘겨 long타입으로 처리
    - double타입은 표기 문제로 인해 long타입으로 진행
    long result = n * n * n;
    Console.WriteLine(long);
    Console.WriteLine(3);
    로 하면 끝
    */
}