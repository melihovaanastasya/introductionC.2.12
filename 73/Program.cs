// 73. Найти сумму элементов от M до N, N и M заданы

int Sum(int n,int m)
{
    if (n==m) return n;
    else return Sum(n+1,m)+n;

}

System.Console.WriteLine(Sum(1,3));