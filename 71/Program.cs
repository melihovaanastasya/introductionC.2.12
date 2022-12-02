// 71. Показать натуральные числа от N до 1, N задано

void Loop (int N, int i)
{
    if (N<=i)
    {
        System.Console.WriteLine(N);
        Loop(N+1,i);
    }
}

Loop(-10,1);