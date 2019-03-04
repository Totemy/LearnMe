using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPersonage
{
    class Program
    {

        static void Main(string[] args)
        {

            int value = Convert.ToInt32(Console.ReadLine());
            Person [] array = new Person [value];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Input name {i} person");
                string name = Console.ReadLine();
                Console.WriteLine($"Input surname {i} person");
                string surname = Console.ReadLine();
                Console.WriteLine($"Input age {i} person");
                int age = Convert.ToInt32(Console.ReadLine());
                array[i] = new Person(name, surname, age);
            }
           for (int i = 0; i < array.Length; i++)
            {
                
                //Console.WriteLine($"Name {array[i].name} Surname {array[i].surname} Age {array[i].age}");
                Console.WriteLine(array[i]);
            }
            Console.ReadKey();
        }
    }
}
