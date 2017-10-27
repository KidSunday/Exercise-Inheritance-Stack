using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExerciseInheritance
{
   class Program
    {
        static void Main(string[] args)
        {
            //Exercises for Section 4, Lecture 26 of C# Intetmediate Classes
            //https://www.udemy.com/csharp-intermediate-classes-interfaces-and-oop
            //Inheritance Exercise 1
            //Create a Stack 

            //Test Implementation Code for Exercise
            var stack = new Stack();
            
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            stack.Clear();
            //Intended output should be: 3, 2, 1

            //
            //Personal Unit Tests
            //
            var stack2 = new Stack();

            //Console.WriteLine(stack2.Pop()); //Test Empty Stack Pop
            //stack2.Push(null); //Test Null stack Push
            stack2.Push(7);
            stack2.Push(12);
            stack2.Push(5);
            stack2.Push("test string");

            //No clear path to List Must manually Pop - No ForEach
            Console.WriteLine(stack2.Pop());
            Console.WriteLine(stack2.Pop());
            Console.WriteLine(stack2.Pop());
            Console.WriteLine(stack2.Pop());

            //Clean up our Stack
            stack2.Clear();

        }
    }
}

