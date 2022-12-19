// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Console.WriteLine("Введите трехзначное число. Выйти из программы команда:  Exit.");
//     while(true)
//     {
//         string input = Console.ReadLine();
//         if(!input.Equals("exit"))
//             Console.WriteLine("{0}->{1}",input, input[1]);
//         else
//             break;
//     }

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// int number = ReadInt("Введите число: ");
// int count = number.ToString().Length;
// Console.Write(MakeArray(number, count));

// // Функция принимает сообщение для отображения в консоли, и выводит результат введенных данных пользователем.
// int ReadInt(string message)
// {
//     Console.Write(message);
//     return Convert.ToInt32(Console.ReadLine());
// }

// // Функция принимает число введенное пользователем, количество символов, и выводит третью цифру числа. Если 3 цифры нет, сообщает и выводит 0.
// int MakeArray(int a, int b)
// {
// int result = 0;
//     if (b < 3)
//     {
//         Console.Write("Третьей цифры нет, держи: ");
//     }
//     else
//     {
//         int c = 1;
//         for (int i = b; i > 3; i--)
//         {
//             c = c * 10;
//         }

//         result = (a / c) % 10;
//     }
// return result;
// }

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text.RegularExpressions;

// namespace home_Work_15
// {
// 	public class Program
// 	{
// 		public static void Main(string[] args)
// 		{
// 			      Console.WriteLine ("Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.");
//       Console.WriteLine ("Введите день недели...");
//       int dayofweek = int.Parse (Console.ReadLine());
//       if (dayofweek == 6 || dayofweek == 7) Console.WriteLine ("Ответ: Выходной день.");
//       else if (dayofweek <= 5) Console.WriteLine ("Ответ: Будний день.");
//       else if (dayofweek > 7) Console.WriteLine ("Ошибка: В неделе всего 7 дней!");
// 		}
// 	}
// }
