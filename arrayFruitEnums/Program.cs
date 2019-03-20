using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayFruitEnums
{
    class Program
    {
        public enum Fruit
        {
            unavailable, melon, strawberry, apple, kiwi, pineapple, tomato
        }

        static void Main(string[] args)
        {
            Fruit[] fruits = new Fruit[3]; //3 is the number of elements in the array
            string userResponse;


            for (int index = 0; index < 3; index++)
            {

                Console.WriteLine($"Enter Fruit choice #{index + 1}: ");
                userResponse = Console.ReadLine();
                //we want to parse the response into the enum, and put that response into the index of the array
                Enum.TryParse(userResponse, out fruits[index]);
                
            }
            Console.WriteLine();

            foreach (Fruit fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Console.ReadKey();

        }

    }

}


