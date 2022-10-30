//Напишите цикл, который принимает на вход два числа 
//(A и B) и возводит число A в натуральную степень B

Console.WriteLine("введите число A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число B");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for (int i = 1; i < b; i++)
{
step = step * a;
}
Console.WriteLine("A в степени B: " + step);



//Напишите программу, которая принимает на вход число
//и выдаёт сумму цифр в числе.

Console.WriteLine("введите число");
int number = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (number > 0)
{
int num = number % 10;
number = number / 10;
sum = sum + num;
}
Console.WriteLine("сумма цифр равна: " + sum);







//Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.


int[] ArrayNum = GenerateArray();
int[] GenerateArray()

{
    int[] ArrayNum = new int[8];

    for (int i = 0; i < ArrayNum.Length; i++)
    {
        
        Console.WriteLine("введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        ArrayNum[i] = number;
    }
    return ArrayNum;
}
void PrintArray(int[] col)
{
    int count = col.Length;

    int position = 0;

    while (position < count)
    {
        Console.Write(col[position]);

        Console.Write(" ");

        position++;
    }
}
PrintArray(ArrayNum);