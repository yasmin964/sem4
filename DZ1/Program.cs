//напишите цикл который принимает на вход два числа a и b и возводит число a в натуральную степень b
int GetPow(int A,int B)
{
    int ans=1;
    for (int i=1;i<=B;i++);
    {
        ans*=A;
    }
    return ans;
}
Console.Write("введите число а:");
Console.Write("введите число b:");
int N=int.Parse(Console.ReadLine()!);
Console.WriteLine(GetPow(N));

