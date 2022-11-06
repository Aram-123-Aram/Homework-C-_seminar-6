/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь. 
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */
int Sum_num = 0;

Console.Write("Enter the number M= ");
int.TryParse(Console.ReadLine(),out int M);

Console.WriteLine($"Enter {M} numbers: ");
for(int i = 0; i < M; i++) 
{
int.TryParse(Console.ReadLine(),out int Mn);
if(Mn > 0) Sum_num = Sum_num + 1;
}
Console.Write($"    -> {Sum_num}     ---(Вы ввели {Sum_num} чисел больше 0!!!)");