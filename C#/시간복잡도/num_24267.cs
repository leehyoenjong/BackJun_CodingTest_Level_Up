class num_24267
{
    static void mains()
    {
        long n = long.Parse(Console.ReadLine());

        long result = n * (n - 2) * (n - 1) / 6;
        Console.WriteLine(result);
        Console.WriteLine(3);
    }

    /*
    MenOfPassion(A[], n) {
        sum <- 0;
        for i <- 1 to n - 2
            for j <- i + 1 to n - 1
                for k <- j + 1 to n
                    sum <- sum + A[i] × A[j] × A[k]; # 코드1
        return sum;
    }

    알고리즘 이해
    - 삼중 반복문으로 알고리즘 수행 시간이 최고다항은 3이며
    - "첫째 줄에 입력의 크기 n(1 ≤ n ≤ 500,000)이 주어진다."이기 때문에 500,000 * 499,999 / 2 = 124,999,750,000로 int값인 21억을 넘겨 long타입으로 처리
    - double타입은 표기 문제로 인해 long타입으로 진행
    long result = n * (n - 2) * (n - 1) / 3;
    Console.WriteLine(result);
    Console.WriteLine(3);
    로 하면 끝
    */
}