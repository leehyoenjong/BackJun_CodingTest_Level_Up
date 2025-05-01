public class num_2480
{
    public void Main()
    {
        string[] input = Console.ReadLine().Split();

        var first = int.Parse(input[0]);
        var second = int.Parse(input[1]);
        var three = int.Parse(input[2]);

        int[] linq = { first, second, three };
        var group = linq.GroupBy(x => x).ToList();

        int result = 0;
        //다 같은 눈일때 
        if (group.Count == 1)
        {
            result = 10000 + group[0].Key * 1000;
        }
        //두개만 같은 눈일때 
        else if (group.Count == 2)
        {
            var samegroup = group.FirstOrDefault(x => x.Count() == 2);
            result = 1000 + samegroup.Key * 100;
        }
        //다 다른 눈일때 
        else
        {
            result = linq.Max() * 100;
        }
        Console.WriteLine(result);
    }
}