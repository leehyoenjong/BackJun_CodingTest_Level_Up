class num_24264
{
    void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(Math.Pow(n, 2));
        Console.WriteLine(2);
    }

    /*
    MenOfPassion(A[], n) {
        sum <- 0;
        for i <- 1 to n
            for j <- 1 to n
                sum <- sum + A[i] × A[j]; # 코드1
        return sum;
    }

    알고리즘 이해
    - 이중 반복문으로 알고리즘 수행 시간이 n*n이기 때문에 최고차항은 2이며 O(n^2)로 판단
    Console.WriteLine(n);
    Console.WriteLine(2);
    로 하면 끝
    */
}