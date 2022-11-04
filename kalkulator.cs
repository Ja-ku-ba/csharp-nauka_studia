/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main(string[] args)
  {
     Console.Write("Podaj pierwszą liczbę: ");
     double first = Convert.ToDouble(Console.ReadLine());
     Console.Write("Podaj operator (+, -, *, /): ");
     string op = Console.ReadLine();
     Console.Write("Podaj drugą liczbę: ");
     double sec = Convert.ToDouble(Console.ReadLine());
     
     if (op == "+"){
         Console.WriteLine(first + sec);
     }
     else if (op == "-"){
         Console.WriteLine(first - sec);
     }
     else if (op == "*"){
         Console.WriteLine(first * sec);
     }
     else if (op == "/"){
         if (sec == 0){
             Console.WriteLine("Dzielisz przez zero");
         }
         else{
             Console.WriteLine(first / sec);
         }
     }
     else{
         Console.WriteLine("Wprowadzono nieprawidłowy operator");
     } 
     Console.ReadKey();
  }
}
