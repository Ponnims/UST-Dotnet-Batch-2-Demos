using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CsharpFeatures
{
    
    // 2 types of collections in C#:
    // 1. Non-generic collections: These collections can store any type of data, and they are not type-safe. Examples include ArrayList, Hashtable, and Queue.
    // 2. Generic collections: These collections are type-safe and can only store a specific type of data. Examples include List<T>, Dictionary<TKey, TValue>, and Queue<T>.
    internal class CollectionsDemo
    {
        static void Main(string[] args)
        {
            // non generic collection
            ArrayList listofdetails = new ArrayList();
            listofdetails.Add("John");
            listofdetails.Add(25);
            listofdetails.Add('A');
            listofdetails.Add(3.14);
            listofdetails.Add(true);

            int sum = 0;
            foreach (var item in listofdetails)
            {
                sum += (int)item; // This will throw an exception because the collection contains different types of data
            }

            Hashtable ht = new Hashtable();
            ht.Add("Name", "John");
            ht.Add("Age", 25);
            ht.Add("Initial", 'A');
            ht.Add("Pi", 3.14);
            ht.Add("IsEmployed", true);
            ht.Add(200, "Two Hundred");

            SortedList sl = new SortedList();
            sl.Add("Name", "John");
            sl.Add("Age", 25);
            sl.Add("Initial", 'A');
            sl.Add("Pi", 3.14);

            Stack stack = new Stack(); // LIFO
            stack.Push("John");
            stack.Push(25);
            stack.Push('A');
            stack.Push(3.14);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            stack.Pop(); // removes the last item added to the stack, which is 3.14
            stack.Peek(); // returns the last item added to the stack without removing it, which is 'A'

            Queue queue = new Queue(); // FIFO
            queue.Enqueue("John");
            queue.Enqueue(25);
            queue.Enqueue('A');
            queue.Enqueue(3.14);

            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }

            queue.Dequeue(); // removes the first item added to the queue, which is "John"
            queue.Peek(); // returns the first item added to the queue without removing it, which is 25

            // generic collections

            List<int> scoreslist = new List<int>();
            scoreslist.Add(90);
            scoreslist.Add(85);
            scoreslist.Add(95);
            // scoreslist.Add("ghfgh"); // This will throw an error because the collection is type-safe and can only store integers

            Dictionary<string, int> scoresdict = new Dictionary<string, int>();
            scoresdict.Add("John", 90);
            scoresdict.Add("Jane", 85);
            scoresdict.Add("Bob", 95);

            Stack<string> stackofnames = new Stack<string>();
            stackofnames.Push("John");
            stackofnames.Push("Jane");
            stackofnames.Push("Bob");



            // collection Initializer syntax
            List<int> myscores = new List<int>() { 90, 85, 95, 80, 88 };
            List<string> mynames = new List<string>() { "John", "Jane", "Bob" };




        }
    }
}
