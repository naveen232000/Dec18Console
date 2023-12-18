using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dec18Console
{
    internal class SystemArray
    {
        public static void ArraylistFun()
        {
            ArrayList arry = new ArrayList();
            arry.Add(1);
            arry.Add(2);
            arry.Add(3);
            arry.Add(4);
            arry.Add(5);
            arry.Add(6);
            //for
            foreach(int i in arry)
            {
                Console.Write($"{i} ");
            }
            arry.Remove(1);
            arry.RemoveAt(2);
            Console.WriteLine("\narry.Remove(1)   arry.RemoveAt(2)");
            foreach (int i in arry)
            {
                Console.Write($"{i} ");
            }


            arry.RemoveRange(1,1);
            Console.WriteLine("\narry.RemoveRange(1,3)");
            foreach (int i in arry)
            {
                Console.Write($"{i} ");
            }

            int n1 = arry.Count;
            int n2 = arry.Capacity;
            
            bool b1= arry.Contains(1);
            int ind= arry.IndexOf(6);
            Console.WriteLine($"\narray.count = {n1}\narray.capacity ={n2}\narray.contains(1) :{b1}\narray.indedof(6)={ind}");
            
            arry.Insert(0, 12);
            Console.WriteLine("arry.Insert(0, 12)");
            foreach (int i in arry)
            {
                Console.Write($"{i} ");
            }
            
            arry.Clear();
            Console.WriteLine("\narry.Clear()");
            int n3 = arry.Count;
            Console.WriteLine($"array.count = {n3}");
        }
        public static void HastableFun()
        {
            Hashtable has1 = new Hashtable();
            has1.Add("Name", "Naveen");
            has1.Add("Email", "nav@gmail.com");
            has1.Add("Phone", 112121212);
            has1.Add("City", "Dh");
            Console.WriteLine("All Keys\n");
            ICollection has1keys =has1.Keys;
            foreach (var i in has1keys)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("\nAll Values\n");
            ICollection has1value = has1.Values;
            foreach (var i in has1value)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nkey : value\n");
            foreach(DictionaryEntry i in has1)
            {
                Console.WriteLine($"{i.Key} : {i.Value}");
            }
            bool b1=has1.ContainsKey("Name");
            bool b2=has1.ContainsValue("Dh");
            bool b3 = has1.Contains("Email");
            int n1=has1.Count;
            Console.WriteLine($"\nhas1.ContainsKey(\"Name\") = {b1}\nhas1.ContainsValue(\"Dh\") = {b2}\nhas1.Contains(\"Email\") = {b3}\nhas1.Count = {n1}");
            DictionaryEntry[] hasCopy = new DictionaryEntry[has1.Count];
            has1.CopyTo(hasCopy, 0);
            Console.WriteLine("\n has1.CopyTo\n");
            foreach (DictionaryEntry str in hasCopy)
            {
                Console.WriteLine(str.Key);
            }
            Console.WriteLine("\nhas1.Remove(\"City\")\n");
            has1.Remove("City");
            foreach (DictionaryEntry i in has1)
            {
                Console.WriteLine($"{i.Key} : {i.Value}");
            }
        }
    }

}
