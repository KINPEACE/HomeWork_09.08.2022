//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходны.

Console.Write("Введите цифру обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

void num1 (int num)
{}
if(num == 6 || num == 7)
    {
        Console.WriteLine("Да, это выходной!");
    }
else if(num < 1 || num > 7)
    {
        Console.WriteLine("Эта цифра никак не относится ко дням недели");    
    }
else Console.WriteLine("Нет, это не выходной!");

