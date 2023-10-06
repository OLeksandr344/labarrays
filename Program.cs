using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

class Program
{

    static void Main()
    {      
        while (true)
        {
       
            Console.WriteLine("Виберіть завдання:");
            Console.WriteLine("1. Завдання номер 1");
            Console.WriteLine("2. Завдання номер 2");
            Console.WriteLine("3. Завдання номер 3");
            Console.WriteLine("4. Завдання номер 4");
            Console.WriteLine("5. Завдання номер 5");
            Console.WriteLine("6. Завдання номер 6");
            Console.WriteLine("7. Завдання номер 7");
            Console.WriteLine("8. Завдання номер 8");
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
    static void Avg()
    {
        int[] numbers = new int[0];
        while (true)
        {
            Console.Write("добавьте число в массив - ");
            string input = Console.ReadLine();
            if (input.ToLower() == "n")
            {
                int sum = 0;
                int array_numbers = numbers.Length;
                double avg_array = 0;
                foreach (int num in numbers)
                {
                    sum += num;
                    avg_array = sum / array_numbers;

                }
                Console.WriteLine($"середнє арифметичне всіх елементів у заданому масиві цілих чисел - {avg_array} ");
                break;
            }
            else if (int.TryParse(input,out int num))
            {
                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[numbers.Length - 1] = num;
            }
            Console.WriteLine("Массив: " + string.Join(", ", numbers));
        }

    }
    static void Palindrome()
    {
        int[] numbers = new int[0];
        bool check = true;
        while (true)
        {
            Console.Write("добавьте число в массив - ");
            string input = Console.ReadLine();
            if (input.ToLower() == "n")
            {
                int length = numbers.Length;
                for (int i = 0; i < length / 2; i++)
                {
                    if (numbers[i] != numbers[length - 1 - i])
                    {
                        check = false;
                        break;
                    }
                }
                if (check)
                {
                    Console.WriteLine("Масив є паліндромом.");
                }
                else
                {
                    Console.WriteLine("Масив не є паліндромом.");
                }
                
                break;
            }
            else if (int.TryParse(input, out int num))
            {
                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[numbers.Length - 1] = num;
            }
            Console.WriteLine("Массив: " + string.Join(", ", numbers));
        }

    }
    static void Parni()
    {
        int[] numbers = new int[0];
        StringBuilder parni_chysla = new StringBuilder();
        while (true)
        {
            Console.Write("добавьте число в массив - ");
            string input = Console.ReadLine();
            if (input.ToLower() == "n")
            {
                bool first = true;

                foreach (int number in numbers)
                {
                    if (number % 2 == 0)
                    {
                        if (!first)
                        {
                            parni_chysla.Append(", ");
                        }
                        parni_chysla.Append(number);
                        first = false;
                    }
                }
                Console.WriteLine($"Парні числа: {parni_chysla}");
                break;
            }

            else if (int.TryParse(input, out int num))
            {
                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[numbers.Length - 1] = num;
            }
            Console.WriteLine("Массив: " + string.Join(", ", numbers));
        }

    }
    static void Sum()
    {
        int[] numbers = new int[0];
        int sum = 0;
        while (true)
        {
            Console.Write("добавьте число в массив - ");
            string input = Console.ReadLine();
            if (input.ToLower() == "n")
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

            else if (int.TryParse(input, out int num))
            {
                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[numbers.Length - 1] = num;
            }
            Console.WriteLine("Массив: " + string.Join(", ", numbers));
        }

    }
    static void IndexFind()
    {
        int[] numbers = new int[0];
        int sum = 0;
        while (true)
        {
            Console.Write("добавьте число в массив - ");
            string input = Console.ReadLine();
            if (input.ToLower() == "n")
            {
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
                break;
            }

            else if (int.TryParse(input, out int num))
            {
                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[numbers.Length - 1] = num;
            }
            Console.WriteLine("Массив: " + string.Join(", ", numbers));
        }

    }
    static void Sum1()
    {
        int[] numbers = new int[0];
        int product = 1;
        while (true)
        {
            Console.Write("добавьте число в массив - ");
            string input = Console.ReadLine();
            if (input.ToLower() == "n")
            {
                foreach (int number in numbers)
                {
                    if (number < 0)
                    {
                        product *= number;
                    }
                }
                Console.WriteLine($"Добуток від'ємних чисел - {product}");

                break;
            }

            else if (int.TryParse(input, out int num))
            {
                Array.Resize(ref numbers, numbers.Length + 1);
                numbers[numbers.Length - 1] = num;
            }
            Console.WriteLine("Массив: " + string.Join(", ", numbers));
        }

    }
    static void Matrix()
    {
        while (true)
        {
            Console.Write("Введіть кількість рядків: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "n") 
            {
                break;
            }
            else if (int.TryParse(input, out int rows))
            {
                Console.Write("Введіть кількість стовпчиків: ");
                int cols = int.Parse(Console.ReadLine());

                int[,] matrix = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write($"Введіть елемент [{i},{j}]: ");
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                int sum = 0;
                for (int i = 0; i < Math.Min(rows, cols); i++)
                {
                    sum += matrix[i, i];
                }           
                Console.WriteLine($"Сума елементів на головній діагоналі: {sum}");         
             }                          
        }
    }
    static void Matrix90()
    {
        while (true)
        {
            Console.Write("Введіть кількість рядків: ");
            string input = Console.ReadLine();
            if (input.ToLower() == "n")
            {
                break;
            }
            else if (int.TryParse(input, out int rows))
            {
                Console.Write("Введіть кількість стовпчиків: ");
                int cols = int.Parse(Console.ReadLine());

                int[,] matrix = new int[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write($"Введіть елемент [{i},{j}]: ");
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("Матриця:");
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        Console.Write(matrix[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
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
    }
}
    
