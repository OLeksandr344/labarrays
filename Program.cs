using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

class Program
{
    static void Main()
    {      
        while (true)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Виберіть завдання:");
            Console.WriteLine("1. Завдання номер 1");
            Console.WriteLine("2. Завдання номер 2");
            Console.WriteLine("3. Завдання номер 3");
            Console.WriteLine("4. Завдання номер 4");
            Console.WriteLine("5. Завдання номер 5");
            Console.WriteLine("6. Завдання номер 6");
            Console.WriteLine("7. Завдання номер 7");
            Console.WriteLine("8. Завдання номер 8");
            Console.WriteLine("-------------------");
            Console.Write("Номер завдання (або 'n' для виходу): ");
            string input = Console.ReadLine();       
            Console.Clear();
            if (input.ToLower() == "n")
            {
                break;
            }

            else if (int.TryParse(input, out int choice))
            {
                switch (choice)
                {
                    case 1:
                        Avg();
                        break;
                     case 2:
                        Palindrome();
                        break;
                     case 3:
                        Parni();
                        break;
                     case 4:
                        Sum();
                        break;
                     case 5:
                        IndexFind();
                        break;
                     case 6:
                        Sum1();
                        break;
                     case 7:
                        Matrix();
                        break;
                     case 8:
                        Matrix90();
                        break;
                }
            }
            else
            {
                Console.WriteLine("Помилка!");
            }
        }
   
    }
    public static int[] numbers = new int[0];
    public static void ADDarray() 
    {
        numbers = new int[0];
        while (true)
        {
            Console.Write("добавьте число в массив ('n'- щоб закінчити) - ");
            string input = Console.ReadLine();
            if (input.ToLower() == "n")
            {
                Console.WriteLine("-------------------");
                break;
            }
            else if (int.TryParse(input, out int num))
            {
                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[numbers.Length - 1] = num;
            }       
            Console.WriteLine("Массив: " + string.Join(", ", numbers));
            Console.WriteLine("-------------------");
        }
    }
    
    static void Avg()
    {
        ADDarray();
        
        while (true)
        {                               
           double sum = 0;
           double array_numbers = numbers.Length;
           double avg_array = 0;
           foreach (double num in numbers)
           {
               sum += num;
               avg_array = sum / array_numbers;

           }
           Console.WriteLine($"середнє арифметичне всіх елементів у заданому масиві цілих чисел - {avg_array} ");
            
            break;
                     
        }

    }
    static void Palindrome()
    {
        ADDarray();             
        while (true)
        {  
            string result = "";
            int length = numbers.Length;
            for (int i = 0; i < length / 2; i++)
                {
                if (numbers[i] != numbers[length - 1 - i])
                    {
                        result = "Масив не є паліндромом.";
                        break;
                    }
                else
                {
                    result = "Масив є паліндромом.";
                }
            }
            Console.WriteLine(result);
            break;                     
        }

    }
    static void Parni()
    {
        ADDarray();               
        while (true)
        {
            string parni_chysla_str = "";
            List<int> parni_chysla = new List<int>();
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    parni_chysla.Add(number);
                    parni_chysla_str = string.Join(", ", parni_chysla);                                     
                }
            }
            Console.WriteLine($"Парні числа: {parni_chysla_str}");            
            break;
        }          
        
    }
    static void Sum()
    {
        ADDarray();      
        int sum = 0;
        while (true)
        {         
            foreach (int number in numbers)
                {
                 if (number > 0)
                    {
                        sum += number;
                    }
                }
                Console.WriteLine($"Сума додатніх чисел - {sum}");
            
            break;
            }                
    }
    static void IndexFind()
    {
        ADDarray();         
        Console.Write("елемент масива - ");
        string elem = Console.ReadLine();
        int.TryParse(elem, out int element);

        for (int i = 0; i < numbers.Length; i++)
        {

            if (numbers[i] == element)
            {
                Console.WriteLine($"Найменший індекс елемента {element} - {i} ");
                
                break;
            }                 
        
        }
    }
    static void Sum1()
    {
        ADDarray();
        int product = 1;
        while (true)
        {          
            foreach (int number in numbers)
              {
                    if (number < 0)
                    {
                        product *= number;
                    }
                }
            if (product != 1) 
            { 
            Console.WriteLine($"Добуток від'ємних чисел - {product}");
            
            }
            else 
            {
                Console.WriteLine("Від'ємних чисел немає");
            }
            break;                    
        }

    }

    public static int cols = 1;
    public static int rows = 1;
    public static int[,] matrix = new int[rows, cols];
    public static void Addmatrix()
    {
        while (true)
        {
            Console.Write("Введіть кількість рядків: ");
             rows = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");
            Console.Write("Введіть кількість стовпчиків: ");
             cols = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------");
            matrix = new int[rows, cols];
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write($"Введіть елемент [{i},{j}]: ");
                        matrix[i, j] = int.Parse(Console.ReadLine());                       
                     }
                
                }
            Console.WriteLine("-------------------");
            Console.WriteLine("Матриця:");
            for (int i = 0; i < rows; i++)
                {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();             
            }
            Console.WriteLine("-------------------");

            break;       
        }
    }
    static void Matrix()
    {
        Addmatrix();    
        int sum = 0;
        for (int i = 0; i < Math.Min(rows, cols); i++)
        {
                    sum += matrix[i, i];
         }           
                Console.WriteLine($"Сума елементів на головній діагоналі: {sum}");         
             }                                
    
    static void Matrix90()
    {
        Addmatrix();
        
                Console.WriteLine("Матриця90:");
                for (int j = cols - 1; j >= 0; j--)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }               
    }
    
    
    
}
    
