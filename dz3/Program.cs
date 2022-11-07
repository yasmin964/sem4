// напишите программу,которая задает масси из 8 элементов и выводит их на экран
int [] GetRandomArray()
{
    int []arr=new int [8];
    for (int i=0;i<8;i++);
    {
        arr[i]=Next(0,2);
    }
    return arr;}
Console.Write("Введите 8 чисел:");
int N=int.Parse(Console.Readline()!);
Console.WriteLine(GetRandomArray(N));
