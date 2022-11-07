//напишите программу,котрая принимает число А и выдает произвеедение чисел,входящих в него
int GetСol (int A)
{
    int sum=1;

    for(int i =1;i<=A;i++)
    {
    sum=sum*i;
    }
    return sum;
}
Console.Write("введите число:");
int N=int.Parse(Console.ReadLine()!);//считываеь и образует строку
Console.WriteLine(GetCol(N));

