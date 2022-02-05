using System;


namespace Generics{

    class Program
    {
       public static void Main()
       {
            MyStack<int> myStack = new MyStack<int>();
           
            myStack.Push(11);
            myStack.Push(21);
            myStack.Push(34);
            myStack.Push(24);
            myStack.Push(57);

            //length of the stack
            int x = myStack.Count();

            Console.WriteLine("Before popping");
            //print the values
            myStack.print();

            //get the length
            Console.WriteLine("Length = "+ x);

            Console.WriteLine();

            int popedValue = myStack.Pop();

            Console.WriteLine("After popping");
            //print the values
            myStack.print();

            Console.WriteLine("Popped Value: "+ popedValue);
            Console.WriteLine("Length = " + x);
            Console.ReadLine();
       }
    }
}

