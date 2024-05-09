// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется 
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

using System;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Введите строку из слов, разделенных пробелами:");
        string input = Console.ReadLine(); // Получаем ввод от пользователя
        string[] originalArray = input.Split(' '); // Разбиваем введенную строку на элементы массива по пробелам и сохраняем в массив

        PrintArray(originalArray);

        //
        // Функции
        //

        void PrintArray(string[] array) //Функция печати массива
        {
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.Write(array[i] + " ");
            }
            System.Console.WriteLine();
        }
    }

}
