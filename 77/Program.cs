// 77. Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности 0 и 1

int Fib (int N)
{
    if (N==1) return (N-1); 
    if (N==2) return (N-1); 
    else return (Fib(N-1)+Fib(N-2));
}

int N=10;
for (int i=1;i<N+1;i++) System.Console.Write($"{Fib(i)} ");