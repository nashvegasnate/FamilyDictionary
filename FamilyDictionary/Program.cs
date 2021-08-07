using System;
using System.Collections.Generic;

namespace FamilyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, string>> 
            myFamily = new Dictionary<string, Dictionary<string, string>>();

            myFamily.Add("brother", new Dictionary<string, string>() { { "name", "Martin" }, { "age", "50" } });
            myFamily.Add("mother", new Dictionary<string, string>() { { "name", "Suzanne" }, { "age", "78" } });
            myFamily.Add("other brother", new Dictionary<string, string>() { { "name", "Lex" }, { "age", "56" } });
            myFamily.Add("father", new Dictionary<string, string>() { { "name", "Steve" }, { "age", "74" } });
        
            
            foreach(var (relative, person) in myFamily)
            {
                var who = person["name"]; 
                var howMany = person["age"];

                Console.WriteLine($"{who} is my {relative} and is {howMany} years old");
                
            }
        
        }
    }
}
