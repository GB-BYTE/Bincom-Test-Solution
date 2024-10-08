using System.Reflection.Metadata.Ecma335;

namespace TEST
{
    public class Program
    {
        static void Main(string[] args)
        {
            //SOLUTION TO TASK 1
            Console.WriteLine("\n SOLUTION TO TASK 1 !\n");

            string name = "jane doe";
            int age = 25;
            bool isAdmin = true;
             Console.WriteLine($" Name is {name} \n Age is {age} \n Admin is {isAdmin} \n");
           



            //SOLUTION TO TASK 2
            Console.WriteLine("SOLUTION TO TASK 2 ! \n");
            Console.WriteLine("Enter Number:\n");
            int userNum = Convert.ToInt32(Console.ReadLine());
            if(userNum % 2 == 0)
            {
                Console.WriteLine(userNum + "" + " is an even number \n");
            }
            else
            {
                Console.WriteLine(userNum + "is an odd number");
            }


            //SOLUTION TO TASK 3
            Console.WriteLine("SOLUTION TO TASK 3 ! \n");
            var max = 10;
            for (int i = 1; i <= max; i++)
            {
                Console.WriteLine($"{i} \n");
            }


            //SOLUTION TO TASK 4

            Console.WriteLine("SOLUTION TO TASK 4 ! \n");
            int total = 0;
            int[] MyArr = {2, 4, 6, 8, 10};
            foreach(var arr in MyArr)
            {
                Console.WriteLine($"{arr}\n");
                total += arr;
            }
            Console.WriteLine($"The Sum of all element is: {total} \n");


            //SOLUTION TO TASK 5

            Console.WriteLine("SOLUTION TO TASK 5! \n");
            Greet("Alice");
           
        }
        public static void Greet(string name)
        {
           Console.WriteLine("Hello, " +  name + "!");
        }
    }
    
   
}
