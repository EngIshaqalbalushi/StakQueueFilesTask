using System;

using System.Collections.Generic;

namespace StakQueueFilesTask
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // ReverseStringUsingStack();

            // EvaluatePostfixExpression();

            RotateQueueElementsbyK();




        }
        // Reverse a String Using Stack

        public static void ReverseStringUsingStack()
        {

            Stack<char> ReverseName = new Stack<char>();

            Console.WriteLine("Enter Name ");
             string name= Console.ReadLine();

            for(int i = 0; i < name.Length; i++)
            {

                ReverseName.Push(name[i]);


            }
            Console.WriteLine("");

            for (int i = 0; i < name.Length; i++)
            {
                //ReverseName.Pop()
                Console.Write(ReverseName.Pop());
            }

        }

        // Evaluate Postfix Expression
        public static void EvaluatePostfixExpression()
        
        
        {
            Stack<string> ReverseName = new Stack<string>();


            Console.WriteLine("Enter Nuber 1 ");
            int Number1 =int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number ");
            int Number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Expression ");
            string Expression = Console.ReadLine();

            Console.WriteLine("Enter Number ");
            int Number3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Expression ");
            string Expression1 = Console.ReadLine();
       
       
        
        }




        //  Rotate Queue Elements by K


        public static void RotateQueueElementsbyK()
        {
            Queue<int> numbers = new Queue<int>();
            int count = 1;

            do
            {
                Console.WriteLine("Enter number " + count + "  ");
                int number1 = int.Parse(Console.ReadLine());
                count++;

                numbers.Enqueue(number1);
            } while (count <= 5);

            Console.Write("main queue: ");
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            Console.Write("Enter k ");
            int rotations = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < rotations; i++)
            {
                int rotate = numbers.Dequeue();

                numbers.Enqueue(rotate);
            }

            Console.Write("new queue: ");
            foreach (int i in numbers)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }






    }
}
