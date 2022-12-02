// числа Фиббоначи

int Fib (int N)
{
    if (N==1) return (N-1); 
    if (N==2) return (N-1); 
    else return (Fib(N-1)+Fib(N-2));
}

System.Console.WriteLine(Fib(10));