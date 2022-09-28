
using System;
namespace ZADACHA {
  class Program {
    static void Main(string[] args){
      Console.WriteLine("напиши 2 разных числа");
    double n1 = Convert.ToDouble(Console.ReadLine()!);
     double n2 = Convert.ToDouble(Console.ReadLine());
     if(n1>=n2) Console.WriteLine("максимальное число =" + n1);
     else  Console.WriteLine("максимальное число = " + n2);
    Console.ReadKey();
    }}}
     
      
     
     