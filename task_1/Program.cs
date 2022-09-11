//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
//натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16


int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}

int a = Prompt("Введите число: ");
int b = Prompt("Введите степень числа: ");
Console.WriteLine("Результат: " + GetDegree(a, b));

int GetDegree(int a, int b)
{
    int i = a;
    int count = 0;
    while (count < b - 1)
    {
        a = a * i;
        count++;

    }
    return a;
}