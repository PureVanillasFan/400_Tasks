// See https://aka.ms/new-console-template for more informati
using System;
namespace Taskassssssssssssssss {
 class Program {
   static void Main(string[] args) {
     Console.Write("Введите год целым числом ");
    int year = Convert.ToInt32(Console.ReadLine());
    if (year % 4 == 0 && year % 100 != 0 || year % 400 ==0) {    
       Console.WriteLine(year + " - год высокосный"); 
    } else {    
       Console.WriteLine(year + " - год невысокосный"); 
    }
    Console.ReadKey(); 
  }
 }
}