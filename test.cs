/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    Console.Write("Wprowadz liczbę: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Wprowadz kolejna liczbę: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(num1 + num2);
    Console.ReadKey();
  }
}
