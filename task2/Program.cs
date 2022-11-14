/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30         */

System.Console.WriteLine("Введите число М");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());
int result = 0;

if (n>m){

    System.Console.WriteLine("попробуйте еще раз");
    
}else{

    for (int i = n; i = m; i++){
   
        result += i;
    }
}
System.Console.WriteLine(result);