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
Console.WriteLine("A в степени B равно: " + step);



//Напишите программу, которая принимает на вход число
//и выдаёт сумму цифр в числе.



         





//Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.

/*int[] ArrayNum = GenerateArray();
int[] GenerateArray()

{
    int[] ArrayNum = new int[8];
    
    int number = Convert.ToInt32(Console.ReadLine());
    
    for (int i = 0; i < ArrayNum.Length; i++)
    {
        ArrayNum [i] = number;
    }
    return ArrayNum;
}
void PrintArray(int[]col)
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
PrintArray(ArrayNum);*/