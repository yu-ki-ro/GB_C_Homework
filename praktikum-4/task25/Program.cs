using static System.Console;
Clear();

Write("Input number: ");
int number = int.Parse(ReadLine()!);
Write("Input stepen: ");
int step = int.Parse(ReadLine()!);
int sum=GetStep(number,step);
WriteLine($"A in step B = {sum}");




int GetStep(int A,int B)
{
    int result = 1;
    while (B>0)
    {
        result *= A;
        B--;
    }
    return result;
}