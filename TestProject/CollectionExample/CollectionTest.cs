using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace TestProject.CollectionExample
{
    class CollectionTest
    {
        //public static void Main(string[] args)
        //{
        //    //hashTableExample2();
        //    //dictioanryExample2();
        //    //sortedListExample();
        //    //GenericSortedList();
        //    //sortedListExample2();
        //    //GenericSortedList2();
        //    //StackExamples();
        //    //GenericStackExamples();
        //    //StackExamples2();
        //    //GenericStackExamples2();
        //    //QueueExamples();
        //    //GenericQueueExamples();
        //    //QueueExamples2();
        //    GenericQueueExamples2();
        //}

        public static void GenericListExamples()
        {
            List<int> genericLst = new List<int>();
            genericLst.Add(100);
            genericLst.Add(300);
            genericLst.Add(400);
            genericLst.Add(200);

            foreach (int i in genericLst)
            {
                Console.WriteLine(i);
            }

            genericLst.Remove(100);

            foreach (int i in genericLst)
            {
                Console.WriteLine(i);
            }
        }

        public static void NonGenericArrayListExamples()
        {
            string str = "Tom";
            int x = 10;
            DateTime d = DateTime.Parse("17-mar-2021");

            ArrayList al = new ArrayList();

            al.Add(str);
            al.Add(x);
            al.Add(d);

            foreach (object o in al)
            {
                Console.WriteLine(o);
            }

        }

        public static void dictionaryExamples()
        {
            Dictionary<int, string> dct = new Dictionary<int, string>();
            dct.Add(1, "Tom");
            dct.Add(2, "Alison");
            dct.Add(3, "Ratul");
            dct.Add(4, "Colin");
            foreach (KeyValuePair<int, string> kvp in dct)
            {
                Console.WriteLine(kvp.Key + " : " + kvp.Value);
                Console.WriteLine("\n");
            }

        }

        public static void dictioanryExample2()
        {
            Dictionary<string, string> dct = new Dictionary<string, string>();
            dct.Add("First Name", "LastName");
            dct.Add("Aniaml", "Species");

            foreach (KeyValuePair<string, string> kvp in dct)
            {
                Console.WriteLine(kvp.Key + " : " + kvp.Value);
                Console.WriteLine("\n");
            }
        }

        public static void hashTableExample()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("T", "Tom");
            hashtable.Add("R", "Ratul");
            hashtable.Add(3, "Colin");
            hashtable.Add(4, 100);

            foreach (DictionaryEntry d in hashtable)
            {
                Console.WriteLine(d.Key + ": " + d.Value);
                Console.WriteLine("\n");
            }

        }

        public static void hashTableExample2()
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("t", 1);
            hashtable.Add(true, 2);
            hashtable.Add(2.222, false);

            foreach (DictionaryEntry t in hashtable)
            {
                Console.WriteLine(t.Key + " : " + t.Value);
                Console.WriteLine("\n");
            }
        }

        public static void sortedListExample()
        {

            SortedList sl = new SortedList();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (DictionaryEntry d in sl)
            {
                Console.WriteLine(d.Key + " : " + d.Value);
                Console.WriteLine("\n");

            }
        }

        public static void sortedListExample2()
        {
            SortedList sL = new SortedList();
            sL.Add(1, 100);
            sL.Add(5, 500);
            sL.Add(3, 300);

            foreach (DictionaryEntry dct in sL)
            {
                Console.WriteLine(dct.Key + " : " + dct.Value);
                Console.WriteLine("\n");
            }
        }

        public static void GenericSortedList()
        {
            SortedList<string, string> sl = new SortedList<string, string>();
            sl.Add("ora", "oracle");
            sl.Add("vb", "vb.net");
            sl.Add("cs", "cs.net");
            sl.Add("asp", "asp.net");

            foreach (KeyValuePair<string, string> kvp in sl)
            {
                Console.WriteLine(kvp.Key + " : " + kvp.Value);
                Console.WriteLine("\n");
            }
        }

        public static void GenericSortedList2()
        {
            SortedList<int, int> sL = new SortedList<int, int>();
            sL.Add(10, 10);
            sL.Add(20, 20);
            sL.Add(30, 30);

            foreach (KeyValuePair<int, int> kvp in sL)
            {
                Console.Write(kvp.Key + " : " + kvp.Value);
                Console.WriteLine("\n");
            }
        }

        public static void StackExamples()
        {
            Stack stk = new Stack();
            stk.Push("cs.net");
            stk.Push(1);
            stk.Push("asp.net");
            stk.Push("sqlserver");

            foreach (object o in stk)
            {
                Console.WriteLine(o + "\n");
            }
        }

        public static void StackExamples2()
        {
            Stack stck = new Stack();
            stck.Push(1);
            stck.Push("test");
            stck.Push(false);
            stck.Push(2.55555);

            foreach (object s in stck)
            {
                Console.WriteLine(s + "\n");
            }
        }

        public static void GenericStackExamples()
        {
            Stack<string> stk = new Stack<string>();
            stk.Push("cs.net");
            stk.Push("test");
            stk.Push("asp.net");
            stk.Push("sqlserver");

            foreach (string s in stk)
            {
                Console.WriteLine(s + "\n");
            }
        }

        public static void GenericStackExamples2()
        {
            Stack<int> stck = new Stack<int>();
            stck.Push(1);
            stck.Push(300);
            stck.Push(-500);
            stck.Push(1000);

            foreach (int i in stck)
            {
                Console.WriteLine(i + "\n");
            }

        }

        public static void QueueExamples()
        {
            Queue q = new Queue();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");

            foreach (object o in q)
            {
                Console.WriteLine(o + "\n");
            }
        }

        public static void QueueExamples2()
        {
            Queue qu = new Queue();
            qu.Enqueue(1);
            qu.Enqueue("tom");
            qu.Enqueue(false);

            foreach (object o in qu)
            {
                Console.WriteLine(o + "\n");
            }
        }
        public static void GenericQueueExamples()
        {
            Queue<string> q = new Queue<string>();
            q.Enqueue("cs.net");
            q.Enqueue("vb.net");
            q.Enqueue("asp.net");
            q.Enqueue("sqlserver");

            foreach (object o in q)
            {
                Console.WriteLine(o + "\n");
            }
        }

        public static void GenericQueueExamples2()
        {
            Queue<int> q = new Queue<int>();
            q.Enqueue(1);
            q.Enqueue(500);
            q.Enqueue(35);

            foreach (object o in q)
            {
                Console.WriteLine(o + "\n");
            }
        }
    }
}



