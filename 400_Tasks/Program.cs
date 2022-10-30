// See https://aka.ms/new-console-template for more informati
using System;
namespace Taskassssssssssssssss {
 class Program {
   static void Main(string[] args) {
        Console.WriteLine("Введите размер многомерного массива по вертикали: ");
    string Rows = Console.ReadLine();
    if (Rows != "") {
       if (int.TryParse(Rows, out int rows)) {
          if (rows > 0) {
             int[][] array = new int[rows][];
             for (int i = 0; i < array.GetLength(0); i++) {
                Console.WriteLine($"Введите для {i} сроки элементы:");
                try {
                   array[i] = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                } catch {
                   Console.WriteLine("Ошибка ввода. Не корректная строка!");
                   Console.ReadKey();
                   return;
                }
             }
             Console.WriteLine("Форматированный массив: ");
             for (int i = 0; i < array.GetLength(0); i++) {
                Array.Reverse(array[i]);
                Console.WriteLine(string.Join(" ", array[i]));
             }
          } else Console.WriteLine("Длина не может быть отрицательной");
       } else Console.WriteLine("Ошибка. Неправильное число");
    } else Console.WriteLine("Ошибка. Пустая строка");
    Console.ReadKey();
  }
 }
}