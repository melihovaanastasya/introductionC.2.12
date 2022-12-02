// 75. Написать программу вычисления функции Аккермана

int Akker (int m, int n)
{
    if (m==0) return (n+1);
    if (n==0 && m>0) return Akker(m-1,1);
    else return Akker(m-1,Akker(m,n-1));
}

System.Console.WriteLine(Akker(2,2));