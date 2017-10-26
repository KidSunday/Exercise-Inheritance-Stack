using System;
using System.Collections;

namespace ConsoleAppExerciseInheritance
{
    class Stack
    {
        ArrayList stackList = new ArrayList();

        public void Push(Object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Push cannot be null");
            else
                stackList.Add(obj);
        }

        public object Pop()
        {
            if (stackList.Count == 0)
                throw new InvalidOperationException("Stack is Empty");
            else
            {
                //Return the OBJECT at the end of the Stack
                //First IN, LAST OUT
                int lastElement = stackList.Count - 1;
                object returnValue = stackList[lastElement];
                stackList.RemoveAt(lastElement);

                return returnValue;
            }
        }

        public void Clear()
        {
            stackList.Clear();
            //Console.WriteLine("Stack Cleared"); 
        }
    }
}

