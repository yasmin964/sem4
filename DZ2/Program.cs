int GetSum (int A)
{
    int sum=0;
    for(int i=1;i<=A;i++)
    { sum+=i;

    }
    
    return sum;
}
Console.Write("введите число:");
int N=int.Parse(Console.ReadLine()!);//считываеь и образует строку
Console.WriteLine(GetSum(N));
