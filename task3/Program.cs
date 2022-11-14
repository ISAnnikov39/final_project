/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29     */

System.Console.WriteLine("ВВедите число м");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("ВВедите число n");
int n = Convert.ToInt32(Console.ReadLine());
int Ackerman(int m, int n) {
           // Depth++;
            if (m == 0)
                return n + 1;
            if (n == 0)
                return Ackerman(m - 1, 1);
            return Ackerman(m - 1, Ackerman(m, n - 1));
        }
 
       
 Console.WriteLine(Ackerman(m, n));
      

