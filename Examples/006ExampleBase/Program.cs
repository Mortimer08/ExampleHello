﻿int A = 1;
int B = 2;
int C = 6;
int D = 8;
int E = 10;

int Max = A;

if(A > Max) Max = A;
if(B > Max) Max = B;
if(C > Max) Max = C;
if(D > Max) Max = D;
if(E > Max) Max = E;

Console.Write("Max = ");
Console.WriteLine(Max);   