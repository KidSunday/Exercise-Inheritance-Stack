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

            //Test Implementation Code for Exercise
            var stack = new Stack();
            
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            //Intended output should be: 3, 2, 1


            //Personal Unit Tests
            var stack2 = new Stack();

            //Console.WriteLine(stack2.Pop()); //Test Empty Stack Pop
            //stack2.Push(null); //Test Null stack Push
            stack2.Push(1);
            stack2.Push(2);
            stack2.Push(3);

            Console.WriteLine(stack2.Pop());
            Console.WriteLine(stack2.Pop());
            Console.WriteLine(stack2.Pop());
            
            //Clean up our Stack
            stack2.Clear();

        }
    }
}

