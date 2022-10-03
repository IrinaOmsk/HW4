//Задача 25: Используя определение степени числа, напишите цикл, 
//который принимает на вход два натуральных числа (A и B) 
//и возводит число A в степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
{
Console.Write("Ввести число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввести число B: ");
int b = Convert.ToInt32(Console.ReadLine());
double result = 1;
for (int i = 1; i <= b; i++){
    result = result * a;
}

Console.WriteLine($"{a} ^ {b} = {result}");

}