using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(10);
        stack.Push(20);
        stack.Push(30);

        Console.WriteLine($"Översta elementet i stacken är : {stack.Peek()}");

        stack.Pop();
        stack.Pop();

        Console.WriteLine($"Översta elementet i stacken är : {stack.Peek()}");

    }
}
