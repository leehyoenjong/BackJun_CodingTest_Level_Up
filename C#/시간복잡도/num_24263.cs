class num_24263
{
    void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(n);
        Console.WriteLine(1);
    }

    /*
    MenOfPassion(A[], n) {
        sum <- 0;
        for i <- 1 to n
            sum <- sum + A[i]; # 코드1
        return sum;
    }

    알고리즘 이해
    - MenOfPassion 함수를 보면 for문을 이용해 계산하고 있어 시간복잡도는 O(n)이며, 횟수가 상수가 아니기 때문에 최고차항은 1이다. 고로
    Console.WriteLine(n);
    Console.WriteLine(1);
    로 하면 끝
    */
}