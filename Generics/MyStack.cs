using System;

namespace Generics
{
	class MyStack <T>
	{

        List<T> stack;

        public MyStack()
        {
            stack = new List<T>();
        }

        public int Count()
        {
            return stack.Count;
        }

        public T Pop()
        {
            int length = Count();
            if(length <= 0)
            {
                Console.WriteLine("stack is empthy.");
                throw new IndexOutOfRangeException();
            }

            T pop = stack[length-1];
            stack.RemoveAt(length-1);
            return pop;
        }

        public void Push(T value)
        {
            stack.Add(value);
        }

        public void print()
        {
            for (int i = Count()-1; i >= 0; i--)
            {
                Console.WriteLine(stack[i]);
            }
        }

	}
}

