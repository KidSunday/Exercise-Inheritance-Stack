using System;
using System.Collections;

namespace ConsoleAppExerciseInheritance
{
    class Stack
    {
        private ArrayList _stackList;

        public Stack()
        {
            _stackList = new ArrayList();
        }
        

        public void Push(Object obj)
        {
            if (obj == null)
                throw new InvalidOperationException("Push cannot be null");
            else
                _stackList.Add(obj);
        }

        public object Pop()
        {
            if (_stackList.Count == 0)
                throw new InvalidOperationException("Stack is Empty");
            else
            {
                //Return the OBJECT at the end of the Stack
                //First IN, LAST OUT
                int lastElement = _stackList.Count - 1;
                object returnValue = _stackList[lastElement];
                _stackList.RemoveAt(lastElement);

                return returnValue;
            }
        }

        public void Clear()
        {
            _stackList.Clear();
            //Console.WriteLine("Stack Cleared"); 
        }
    }
}

