//напишите программу,котрая принимает число А и выдает количество чисел

int GetSum (int A)
{
    int sum=0;

    while (A!=0)
    {A=A/10;//достаем каждое число (10-система счисления)
    sum++;
    }
    return sum;
}
Console.Write("введите число:");
int N=int.Parse(Console.ReadLine()!);//считываеь и образует строку
Console.WriteLine(GetSum(N));


