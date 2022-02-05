using System;

namespace Generics{

    class Program
    {
        public static void Main(string [] args)
        {
            MyList<string> myList = new();

            myList.Add("San");
            myList.Add("Akel");
            myList.Add("Angel");
            myList.Add("Kelly");
            myList.Add("Sai");
            myList.Add("Akel");
            myList.Add("Angel");
            myList.Add("Kelly");

            myList.Remove(1);

            //returns true
            myList.Contains("Sai");

            myList.InsertAt("Sohel", 4);
            myList.DeleteAt(3);

            myList.Find(2);


            Console.ReadLine();
        }

    }
}

