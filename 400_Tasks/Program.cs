// See https://aka.ms/new-console-template for more informati
using System;
namespace Taskassssssssssssssss {
 class Program {
   static void Main(string[] args) {
    Console.Write("Введи целое число ");
    double x = Convert.ToDouble(Console.ReadLine());
    if (x>=-5 && x<=-3 || x>=-1 && x<=1 || x>=3 && x<=5) Console.Write("Входит в диапазон");
    else Console.Write("Не входит в диапазон");
    Console.ReadKey(); 
  } 
 }
}