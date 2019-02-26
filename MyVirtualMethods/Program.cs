using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;


namespace VirtualMethodsMy
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseClass class1 = new BaseClass();
            DerivedClass class2 = new DerivedClass();
            BaseClass class3 = new DerivedClass();

            class2.GetName();
            class2.GetAge();
            class3.GetName();
            class3.GetAge();
         
            Dictionary test = new Dictionary();
            test.Test();

            var dictionary = new Dictionary<string, int>();
            dictionary.Add("cat", 2);
            dictionary.Add("dog", 1);
            dictionary.Add("llama", 0);
            dictionary.Add("iguana", -1);
            // The dictionary has 4 pairs.
            Console.WriteLine("DICTIONARY 1: " + dictionary.Count);

            Console.ReadKey(); 
        }
    }

    public class BaseClass
    {
        public void GetName()
        {
            Console.WriteLine("Base name is Masha");
        }

        public virtual void GetAge()
        {
            Console.WriteLine("Base age is 31");
        }
    }

    public class DerivedClass : BaseClass
    {
        public new void GetName()
        {
            Console.WriteLine("Derived name is Tom");
        }

        public override void GetAge()
        {
            Console.WriteLine("Derived age is 38");
        }
    }

    public  class Dictionary
    {
        class StudentName
        {
            public int Age { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Id { get; set; }
        }

        public  void Test()
        {
            Dictionary<int, StudentName> students = new Dictionary<int, StudentName>()
            {
                [111] = new StudentName {FirstName = "Masha", LastName = "T", Id = 11},
                [112] = new StudentName {FirstName = "Nom", LastName = "T", Id = 12},
            };

            foreach (var index in Enumerable.Range(111, 2))
            {
                Console.WriteLine($"Student {index} is {students[index].FirstName} {students[index].LastName}");
            }
    }
        
}
}
