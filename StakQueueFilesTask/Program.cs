using System;
using System.IO;

using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Reflection.PortableExecutable;

namespace StakQueueFilesTask
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // ReverseStringUsingStack();

            // EvaluatePostfixExpression();

            //RotateQueueElementsbyK();
            //SortQueueUsingOnlyQueueOperations();
            //SlidingWindowMaximumUsingQueue();

            //  WriteNamesFile();


            SearchForWordFile();

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
            Stack<int> stack = new Stack<int>();

            Console.WriteLine("Enter postfix expression (e.g. 5 3 + 8 *):");
            string input = Console.ReadLine();

            int i = 0;

            while (i < input.Length)
            {
                char ch = input[i];

                if (ch == ' ')
                {
                    i++;
                    continue;
                }

                // If digit, parse full number (could be multi-digit)
                if (char.IsDigit(ch))
                {
                    int num = 0;
                    while (i < input.Length && char.IsDigit(input[i]))
                    {
                        num = num * 10 + (input[i] - '0');
                        i++;
                    }
                    stack.Push(num);
                }
                else
                {
                    // It's an operator
                    int b = stack.Pop();
                    int a = stack.Pop();

                    switch (ch)
                    {
                        case '+':
                            stack.Push(a + b);
                            break;
                        case '-':
                            stack.Push(a - b);
                            break;
                        case '*':
                            stack.Push(a * b);
                            break;
                        case '/':
                            stack.Push(a / b);
                            break;
                        default:
                            Console.WriteLine($"Unsupported operator: {ch}");
                            return;
                    }

                    i++; // Move past the operator
                }
            }

            // Final result
            Console.WriteLine("Result: " + stack.Pop());



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

        // Sort a Queue Using Only Queue Operations

        public static void SortQueueUsingOnlyQueueOperations()
        {
            Queue<int> queueA = new Queue<int>();
            Queue<int> queueB = new Queue<int>();
            
           
            int count = 1;


            do
            {
                Console.WriteLine("Enter number " + count + "  ");
                int number1 = int.Parse(Console.ReadLine());
                count++;

                queueA.Enqueue(number1);
            } while (count <= 5);


            Console.WriteLine("odd queue") ;
            foreach(int i in queueA)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();


            queueB.Enqueue(queueA.Dequeue());
            while (queueA.Count > 0)
            {
                int next = queueA.Dequeue();
                for (int i = 0; i < queueB.Count; ++i)
                {
                    if (queueB.Peek() < next)
                    {
                        queueB.Enqueue(queueB.Dequeue());
                    }
                    else
                    {
                        queueB.Enqueue(next);
                        next = queueB.Dequeue();
                    }
                }
                queueB.Enqueue(next);
            }

            foreach(int i in queueB)
            {
                Console.Write(i + " ");
            }





        }

        // Sliding Window Maximum Using Queue
        public static void SlidingWindowMaximumUsingQueue()
        {
            Console.WriteLine("Enter  number  ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter the elements:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Element " + (i + 1) + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("enter  k: ");
            int k = int.Parse(Console.ReadLine());

            if (k > n || k <= 0)
            {
                Console.WriteLine("invalid value of k");
                return;
            }

            Queue<int> result = new Queue<int>();



            for (int i = 0; i <= n - k; i++)
            {
                int max = arr[i];
                for (int j = 1; j < k; j++)
                {
                    if (arr[i + j] > max)
                    {
                        max = arr[i + j];
                    }
                }
                result.Enqueue(max);
            }

            Console.WriteLine("Maximum of each subarray of size " + k + ":");
            foreach (int max in result)
            {
                Console.Write(max + " ");
            }

            Console.WriteLine();

        }




        // Write Names to File

        public static void WriteNamesFile()
        {
            string path = "C:\\Users\\Codeline\\Desktop\\k.com.txt";
            // Writing to a file using StreamWriter
            using (StreamWriter writer = new StreamWriter(path,true))
            {
              
                for(int i = 0; i < 5; i++)
                {
                    Console.WriteLine("Enter Name : ");
                    string name = Console.ReadLine();
                    writer.WriteLine(name);
                }
            }
            Console.WriteLine("Text written to file.");
        }


        // Search for a Word in a File


        public static void SearchForWordFile()
        {
            string path = "C:\\Users\\Codeline\\Desktop\\k.com.txt";




            if (File.Exists(path))
            {
                // Writing to a file using StreamWriter
                using (StreamReader reader = new StreamReader(path, true))
                {


                    Console.WriteLine("Enter Word : ");
                    string word = Console.ReadLine().Trim();

                    string content = reader.ReadToEnd(); // Reads the entire file

                   

                    if (word == content)
                    {

                        Console.WriteLine("Word is found.");

                        Console.WriteLine(content);

                    }
                    else
                    {

                        Console.WriteLine("Word not found.");


                    }
                }
            }
            else
            {
                Console.WriteLine("File not found.");

            }




                Console.WriteLine("Text written to file.");
            }


















        }









    }


