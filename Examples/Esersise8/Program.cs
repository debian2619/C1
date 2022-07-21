int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}
int a = 2;
int b = 1;
int c = 6;
int a1 = 8;
int b1 = 4;
int c1 = 10;
int a2 = 37;
int b2 = 35;
int c2 = 355;
//int max1 = Max(a, b, c);
//int max2 = Max(a1, b1, c1);
//int max3 = Max(a2, b2, c2);
//int max = Max(max1, max2, max3);
int max = Max(
    Max(a, b, c),
    Max(a1, b1, c1),
    Max(a2, b2, c2));
Console.WriteLine(max);
