
/*
using System;

class Program
{
    public static double fraction(double x)
    {
        int a = (int)x;
        return x - a;
    }

    static void Main()
    {
        double x;
        while (true)
        {
            Console.Write("Введите число: ");
            if (double.TryParse(Console.ReadLine(), out x))
                break;
            Console.WriteLine("Ошибка! Введите число.");
        }

        Console.WriteLine("Дробная часть: " + fraction(x));
    }
}
*/






/*
using System;

class Program
{

    public static int charToNum(char x)
    {
        return x - '0';
    }

    static void Main()
    {
        Console.WriteLine("Задание. Букву в число");

        char x;
        while (true)
        {
            Console.Write("Введите одну цифру (0-9): ");
            string s = Console.ReadLine();

            
            if (s.Length == 1 && s[0] >= '0' && s[0] <= '9')
            {
                x = s[0];
                break;
            }

            Console.WriteLine("Ошибка! Введите одну цифру от 0 до 9.");
        }

        int result = charToNum(x);
        Console.WriteLine("Число: " + result);
    }
}
*/







/*
using System;

class Program
{
    public static bool is2Digits(int x)
    {
        if (x < 0)
            x = -x;
        return x >= 10 && x <= 99;
    }

    static void Main()
    {
        Console.WriteLine("Задание. Двузначное число");

        int x;
        while (true)
        {
            Console.Write("Введите число: ");
            if (int.TryParse(Console.ReadLine(), out x))
                break;
            Console.WriteLine("Ошибка! Введите целое число.");
        }

        Console.WriteLine("Двузначное: " + is2Digits(x));
    }
}
 
*/






/*
using System;

class Program
{
    public static bool isInRange(int a, int b, int num)
    {
        int min, max;

        if (a < b)
        {
            min = a;
            max = b;
        }
        else
        {
            min = b;
            max = a;
        }

        return num >= min && num <= max;
    }

    
    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            int x;
            if (int.TryParse(Console.ReadLine(), out x))
                return x;
            Console.WriteLine("Ошибка! Введите целое число.");
        }
    }

    static void Main()
    {
        Console.WriteLine(" Задание. Диапазон ");

        int a = ReadInt("Введите первую границу a: ");
        int b = ReadInt("Введите вторую границу b: ");
        int num = ReadInt("Введите число num: ");

        bool result = isInRange(a, b, num);
        Console.WriteLine("Входит в диапазон: " + result);
    }
}

*/







/*
using System;

class Program
{
    public static bool isEqual(int a, int b, int c)
    {
        return a == b && b == c;
    }

    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            int x;
            if (int.TryParse(Console.ReadLine(), out x))
                return x;
            Console.WriteLine("Ошибка! Введите целое число.");
        }
    }

    static void Main()
    {
        Console.WriteLine(" Задание. Равенство ");

        int a = ReadInt("Введите число a: ");
        int b = ReadInt("Введите число b: ");
        int c = ReadInt("Введите число c: ");

        bool result = isEqual(a, b, c);
        Console.WriteLine("Все числа равны: " + result);
    }
}
*/








/*
using System;

class Program
{
    public static int abs(int x)
    {
        if (x < 0)
            return -x;
        else
            return x;
    }

    
    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            int x;
            if (int.TryParse(Console.ReadLine(), out x))
                return x;
            Console.WriteLine("Ошибка! Введите целое число.");
        }
    }

    static void Main()
    {
        Console.WriteLine(" Задание. Модуль числа ");

        int x = ReadInt("Введите число: ");

        Console.WriteLine("Модуль: " + abs(x));
    }
}
*/








/*
using System;

class Program
{
    public static bool is35(int x)
    {
        bool del3 = (x % 3 == 0);
        bool del5 = (x % 5 == 0);

        if (del3 && del5)
            return false;

        return del3 || del5;
    }

    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            int x;
            if (int.TryParse(Console.ReadLine(), out x))
                return x;
            Console.WriteLine("Ошибка! Введите целое число.");
        }
    }

    static void Main()
    {
        Console.WriteLine("Задание. Тридцать пять");

        int x = ReadInt("Введите число: ");

        Console.WriteLine("Результат: " + is35(x));
    }
}
*/










/*
using System;

class Program
{

    public static int max3(int x, int y, int z)
    {
        int max = x;

        if (y > max)
            max = y;

        if (z > max)
            max = z;

        return max;
    }

    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            int x;
            if (int.TryParse(Console.ReadLine(), out x))
                return x;
            Console.WriteLine("Ошибка! Введите целое число.");
        }
    }

    static void Main()
    {
        Console.WriteLine(" Задание. Тройной максимум ");

        int x = ReadInt("Введите число x: ");
        int y = ReadInt("Введите число y: ");
        int z = ReadInt("Введите число z: ");

        Console.WriteLine("Максимум: " + max3(x, y, z));
    }
}
*/









/*
using System;

class Program
{

    public static int sum2(int x, int y)
    {
        int sum = x + y;

        if (sum >= 10 && sum <= 19)
            return 20;

        return sum;
    }

    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            int x;
            if (int.TryParse(Console.ReadLine(), out x))
                return x;
            Console.WriteLine("Ошибка! Введите целое число.");
        }
    }

    static void Main()
    {
        Console.WriteLine(" Задание. Двойная сумма ");

        int x = ReadInt("Введите число x: ");
        int y = ReadInt("Введите число y: ");

        Console.WriteLine("Результат: " + sum2(x, y));
    }
}
*/










/*
using System;

class Program
{
    public static string day(int x)
    {
        switch (x)
        {
            case 1: return "понедельник";
            case 2: return "вторник";
            case 3: return "среда";
            case 4: return "четверг";
            case 5: return "пятница";
            case 6: return "суббота";
            case 7: return "воскресенье";
            default: return "это не день недели";
        }
    }

    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            int x;
            if (int.TryParse(Console.ReadLine(), out x))
                return x;
            Console.WriteLine("Ошибка! Введите целое число.");
        }
    }

    static void Main()
    {
        Console.WriteLine("Задание. День недели ");

        int x = ReadInt("Введите число от 1 до 7: ");

        Console.WriteLine("День недели: " + day(x));
    }
}
*/









/*
using System;

class Program
{
   
    public static string listNums(int x)
    {
        string result = "";

        for (int i = 0; i <= x; i++)
        {
            result += i;
            if (i < x)
                result += " ";
        }

        return result;
    }

  
    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            int x;
            if (int.TryParse(Console.ReadLine(), out x))
                return x;
            Console.WriteLine("Ошибка! Введите целое число.");
        }
    }

    static void Main()
    {
        Console.WriteLine("Задание. Числа подряд ");

        int x = ReadInt("Введите число x: ");

        Console.WriteLine("Результат: " + listNums(x));
    }
}
*/









/*
using System;

class Program
{
    
    public static string chet(int x)
    {
        string result = "0";

        for (int i = 2; i <= x; i += 2)
        {
            result += " " + i;
        }

        return result;
    }

    
    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            int x;
            if (int.TryParse(Console.ReadLine(), out x))
                return x;
            Console.WriteLine("Ошибка! Введите целое число.");
        }
    }

    static void Main()
    {
        Console.WriteLine(" Задание. Чётные числа ");

        int x = ReadInt("Введите число x: ");

        Console.WriteLine("Результат: " + chet(x));
    }
}
*/









/*
using System;

class Program
{
    
    public static int numLen(long x)
    {
        if (x == 0)
            return 1;

        if (x < 0)
            x = -x;

        int count = 0;

        while (x > 0)
        {
            x = x / 10;
            count++;
        }

        return count;
    }

    
    private static long ReadLong(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            long x;
            if (long.TryParse(Console.ReadLine(), out x))
                return x;
            Console.WriteLine("Ошибка! Введите целое число.");
        }
    }

    static void Main()
    {
        Console.WriteLine(" Задание. Длина числа ");

        long x = ReadLong("Введите число x: ");

        Console.WriteLine("Количество знаков: " + numLen(x));
    }
}
*/








/*
using System;

class Program
{
   
    public static void square(int x)
    {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < x; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

 
    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            int x;
            if (int.TryParse(Console.ReadLine(), out x))
                return x;
            Console.WriteLine("Ошибка! Введите целое число.");
        }
    }

    static void Main()
    {
        Console.WriteLine(" Задание. Квадрат ");

        int x = ReadInt("Введите размер квадрата x: ");

        square(x);
    }
}
*/







/*
using System;

class Program
{

    public static void rightTriangle(int x)
    {
        for (int i = 1; i <= x; i++)
        {

            for (int j = 0; j < x - i; j++)
            {
                Console.Write(" ");
            }


            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }
    }


    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            int x;
            if (int.TryParse(Console.ReadLine(), out x))
                return x;
            Console.WriteLine("Ошибка! Введите целое число.");
        }
    }

    static void Main()
    {
        Console.WriteLine(" Задание. Правый треугольник ");

        int x = ReadInt("Введите высоту треугольника x: ");

        rightTriangle(x);
    }
}
*/







/*
using System;

class Program
{

    public static int findFirst(int[] arr, int x)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
                return i;
        }

        return -1;
    }

    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            int x;
            if (int.TryParse(Console.ReadLine(), out x))
                return x;
            Console.WriteLine("Ошибка! Введите целое число.");
        }
    }


    private static int[] ReadArray(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string s = Console.ReadLine();
            string[] parts = s.Split(' ');

            int[] arr = new int[parts.Length];
            bool ok = true;

            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out arr[i]))
                {
                    ok = false;
                    break;
                }
            }

            if (ok)
                return arr;

            Console.WriteLine("Ошибка! Введите целые числа через пробел.");
        }
    }

    static void Main()
    {
        Console.WriteLine(" Задание. Поиск первого значения ");

        int[] arr = ReadArray("Введите элементы массива через пробел: ");
        int x = ReadInt("Введите число для поиска: ");

        int result = findFirst(arr, x);
        Console.WriteLine("Индекс первого вхождения: " + result);
    }
}

*/







/*
using System;

class Program
{

    public static int maxAbs(int[] arr)
    {
        int max = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            int absMax = max;
            int absCur = arr[i];

            if (absMax < 0)
                absMax = -absMax;

            if (absCur < 0)
                absCur = -absCur;

            if (absCur > absMax)
                max = arr[i];
        }

        return max;
    }


    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            int x;
            if (int.TryParse(Console.ReadLine(), out x))
                return x;
            Console.WriteLine("Ошибка! Введите целое число.");
        }
    }

    private static int[] ReadArray(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string s = Console.ReadLine();
            string[] parts = s.Split(' ');

            int[] arr = new int[parts.Length];
            bool ok = true;

            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out arr[i]))
                {
                    ok = false;
                    break;
                }
            }

            if (ok)
                return arr;

            Console.WriteLine("Ошибка! Введите целые числа через пробел.");
        }
    }

    static void Main()
    {
        Console.WriteLine(" Задание. Поиск максимального по модулю ");

        int[] arr = ReadArray("Введите элементы массива через пробел: ");

        Console.WriteLine("Максимум по модулю: " + maxAbs(arr));
    }
}
*/









/*
using System;

class Program
{
 
    public static int[] add(int[] arr, int[] ins, int pos)
    {
        int[] result = new int[arr.Length + ins.Length];

        int k = 0;


        for (int i = 0; i < pos; i++)
        {
            result[k] = arr[i];
            k++;
        }

 
        for (int i = 0; i < ins.Length; i++)
        {
            result[k] = ins[i];
            k++;
        }


        for (int i = pos; i < arr.Length; i++)
        {
            result[k] = arr[i];
            k++;
        }

        return result;
    }


    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            int x;
            if (int.TryParse(Console.ReadLine(), out x))
                return x;
            Console.WriteLine("Ошибка! Введите целое число.");
        }
    }


    private static int[] ReadArray(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string s = Console.ReadLine();
            string[] parts = s.Split(' ');

            int[] arr = new int[parts.Length];
            bool ok = true;

            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out arr[i]))
                {
                    ok = false;
                    break;
                }
            }

            if (ok)
                return arr;

            Console.WriteLine("Ошибка! Введите целые числа через пробел.");
        }
    }

    private static void PrintArray(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i < arr.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }

    static void Main()
    {
        Console.WriteLine(" Задание. Добавление массива в массив ");

        int[] arr = ReadArray("Введите элементы массива arr: ");
        int[] ins = ReadArray("Введите элементы массива ins: ");
        int pos = ReadInt("Введите позицию вставки pos: ");

        int[] result = add(arr, ins, pos);

        Console.Write("Результат: ");
        PrintArray(result);
    }
}
*/










/*
using System;

class Program
{

    public static int[] reverseBack(int[] arr)
    {
        int[] result = new int[arr.Length];

        for (int i = 0; i < arr.Length; i++)
        {
            result[i] = arr[arr.Length - 1 - i];
        }

        return result;
    }


    private static int[] ReadArray(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string s = Console.ReadLine();
            string[] parts = s.Split(' ');

            int[] arr = new int[parts.Length];
            bool ok = true;

            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out arr[i]))
                {
                    ok = false;
                    break;
                }
            }

            if (ok)
                return arr;

            Console.WriteLine("Ошибка! Введите целые числа через пробел.");
        }
    }

    private static void PrintArray(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i < arr.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }

    static void Main()
    {
        Console.WriteLine(" Задание. Возвратный реверс ");

        int[] arr = ReadArray("Введите элементы массива: ");

        int[] result = reverseBack(arr);

        Console.Write("Результат: ");
        PrintArray(result);
    }
}
*/











/*
using System;

class Program
{
 
    public static int[] findAll(int[] arr, int x)
    {
       
        int count = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
                count++;
        }

      
        int[] result = new int[count];

       
        int k = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == x)
            {
                result[k] = i;
                k++;
            }
        }

        return result;
    }

    
    private static int ReadInt(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            int x;
            if (int.TryParse(Console.ReadLine(), out x))
                return x;
            Console.WriteLine("Ошибка! Введите целое число.");
        }
    }

    
    private static int[] ReadArray(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string s = Console.ReadLine();
            string[] parts = s.Split(' ');

            int[] arr = new int[parts.Length];
            bool ok = true;

            for (int i = 0; i < parts.Length; i++)
            {
                if (!int.TryParse(parts[i], out arr[i]))
                {
                    ok = false;
                    break;
                }
            }

            if (ok)
                return arr;

            Console.WriteLine("Ошибка! Введите целые числа через пробел.");
        }
    }

   
    private static void PrintArray(int[] arr)
    {
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
            if (i < arr.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }

    static void Main()
    {
        Console.WriteLine(" Задание. Все вхождения ");

        int[] arr = ReadArray("Введите элементы массива: ");
        int x = ReadInt("Введите число для поиска: ");

        int[] result = findAll(arr, x);

        Console.Write("Индексы вхождений: ");
        PrintArray(result);
    }
}
*/


