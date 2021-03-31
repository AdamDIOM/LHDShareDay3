using System;
using System.Collections.Generic;

namespace SortAList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            Random rand = new Random();
            for(int i = 0; i < 100; i++){
                list.Add(rand.Next(0,100));
            }
            list.Sort();

            foreach(int i in list){
                Console.Write(i + ", ");
            }
        }
    }
}
