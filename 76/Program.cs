﻿// 76. Написать программу возведения числа А в целую положительную степень B

int Power(int a,int b)
{
    if (b>0) return Power(a,b-1)*a;
    else return 1;
}

System.Console.WriteLine(Power(2,3));