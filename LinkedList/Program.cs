using System;
using System.Collections;
using LinkedList.Model;
namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            var list = new LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            showItems(list);

            list.Delete(3);
            list.Delete(1);
            list.Delete(7);

            showItems(list);

            list.AppendHead(7);

            showItems(list);

            list.InsertAfter(5, 9);

            showItems(list);

            Console.ReadLine();
        }

        private static void showItems(IEnumerable list)
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
