// See https://aka.ms/new-console-template for more informati
using System;
namespace Taskassssssssssssssss {
 class Program {
   static void Main(string[] args) {
      Console.Write("Введите целое шестизначное число:  ");
    if (! int.TryParse(Console.ReadLine(), out int n)) {
       Console.WriteLine("вы ввели некорректное число");
       return;
    }  
    int cst = n / 100000;
    int cdt = n / 10000 % 10;
    int cet = n / 1000 % 10;
    int cs  = n / 100 % 10;
    int cd  = n / 10 % 10;
    int ce  = n % 10;
    Console.Write(cst + cdt + cet == cs + cd + ce ? 
                      "номер билета счастливый" : "номер билета не счастливый");
    Console.ReadKey();
  }
 }
}