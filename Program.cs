using System;

namespace GenericDictioanary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(1, "tayfun");
            myDictionary.Add(2, "tayfun");


        }
    }
}
