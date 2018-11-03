/*************************************************************************************
About: This program is written as part of the fulfilment for the ‘put your Unitname’
Course - HND in Computing at Icon College, London.
Date : Put date here
By : Put your name here. Student ID: Put your student ID Here
*************************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = null;
            do
            {
                Console.WriteLine("\tPlease select your choice and enter values 1-4 \n\n\t1) Perfrom non-generic Queue operation." +
                    " \n\n\t2) Perfrom generic Queue operation." +
                    " \n\n\t3) Perfrom non-generic Stack operation." +
                    " \n\n\t4) Perfrom generic Stack operation.\n\n");
                int caseSwitch = GetChoice();
                if (caseSwitch < 0 && caseSwitch > 4)
                {
                    Console.WriteLine("Please enter only int values, enter number 1-4");
                    continue;
                }

                switch (caseSwitch)
                {
                    case 1:
                        QueueOperation();
                        break;
                    case 2:
                        GenericQueueOperation();
                        break;
                    case 3:
                        StackOperation();
                        break;
                    case 4:
                        GenericStackOperation();
                        break;
                    default:
                        break;
                }

                Console.WriteLine("Please press 'Y' to perform more actions otherwise press any other key.");
                answer = Console.ReadLine().ToUpper();
            } while (answer == "Y");

        }

        private static void GenericStackOperation()
        {
            string answer = null;
            GenericStack<int> stack = new GenericStack<int>();

            do
            {
                Console.WriteLine("\tTop of Stack: " + stack.Top);
                Console.WriteLine("\tThe number of jobs in the stack: " + stack.Count);
                Console.WriteLine("\tPlease select your choice and enter values 1-6 \n\n\t1) To add jobs to the stack \n\n\t2) To remove jobs from the stack \n\n\t3) To check the next job in the stack \n\n\t4) To count the number of jobs in the stack \n\n\t5) To clear the stack \n\n\t6)To check job availability of the job\n\n");
                int caseSwitch = GetChoice();
                if (caseSwitch < 0 && caseSwitch > 6)
                {
                    Console.WriteLine("Please enter only int values, enter number 1-6");
                    continue;
                }

                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("\tPlease enter Jobes to add in the Stack:");
                        int value = 0;
                        if (!int.TryParse(Console.ReadLine(), out value))
                        {
                            Console.WriteLine("Provided value isn't type of generic parameter.");
                            break;
                        }
                        stack.Push(value);
                        Console.WriteLine("\tTop: " + stack.Top);
                        break;
                    case 2:
                        Console.WriteLine("\tYour removed job is  " + stack.Pop());
                        Console.WriteLine("\tTop: " + stack.Top);
                        break;
                    case 3:
                        Console.WriteLine("\tNext Job in the Stack is: " + stack.Peek());
                        break;
                    case 4:
                        Console.WriteLine("\tThe number of jobs in the stack: " + stack.Count);
                        break;
                    case 5:
                        Console.WriteLine("\tthe stack is clear .");
                        stack.Clear();
                        break;
                    case 6:
                        Console.WriteLine("\tTo check job availability enter job:");
                        if (!int.TryParse(Console.ReadLine(), out value))
                        {
                            Console.WriteLine("Provided value isn't type of generic parameter.");
                            break;
                        }
                        if (stack.Contains(value))
                        {
                            Console.WriteLine(value + " job is available in the Stack.");
                        }
                        else
                        {
                            Console.WriteLine(value + " job is not available in the Stack.");
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter only int values, enter number 1-6");
                        break;
                }
                Console.WriteLine("Please press 'Y' to perform more actions else press any other key.");
                answer = Console.ReadLine().ToUpper();
            } while (answer == "Y");
        }

        private static void StackOperation()
        {
            string answer = null;
            Stack stack = new Stack();

            do
            {
                Console.WriteLine("\tTop of Stack: " + stack.Top);
                Console.WriteLine("\tThe number of jobs in the stack: " + stack.Count);
                Console.WriteLine("\tPlease select your choice and enter values 1-6 \n\n\t1) To add jobs to the stack \n\n\t2) To remove jobs from the stack \n\n\t3) To check the next job in the stack \n\n\t4) To count the number of jobs in the stack \n\n\t5) To clear the stack \n\n\t6)To check job availability of the job\n\n");
                int caseSwitch = GetChoice();
                if (caseSwitch < 0 && caseSwitch > 6)
                {
                    Console.WriteLine("Please enter only int values, enter number 1-6");
                    continue;
                }

                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("\tPlease enter Jobes to add in the Stack:");
                        stack.Push(Console.ReadLine());
                        Console.WriteLine("\tTop: " + stack.Top);
                        break;
                    case 2:
                        Console.WriteLine("\tYour removed job is  " + stack.Pop());
                        Console.WriteLine("\tTop: " + stack.Top);
                        break;
                    case 3:
                        Console.WriteLine("\tNext Job in the Stack is: " + stack.Peek());
                        break;
                    case 4:
                        Console.WriteLine("\tThe number of jobs in the stack: " + stack.Count);
                        break;
                    case 5:
                        Console.WriteLine("\tthe stack is clear .");
                        stack.Clear();
                        break;
                    case 6:
                        Console.WriteLine("\tTo check job availability enter job:");
                        string value = Console.ReadLine();
                        if (stack.Contains(value))
                        {
                            Console.WriteLine(value + " job is available in the Stack.");
                        }
                        else
                        {
                            Console.WriteLine(value + " job is not available in the Stack.");
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter only int values, enter number 1-6");
                        break;
                }
                Console.WriteLine("Please press 'Y' to perform more actions else press any other key.");
                answer = Console.ReadLine().ToUpper();
            } while (answer == "Y");
        }

        private static void GenericQueueOperation()
        {
            string answer = null;
            GenericQueue<int> queue = new GenericQueue<int>();

            do
            {
                Console.WriteLine("\tFront of Queue: " + queue.Front);
                Console.WriteLine("\tRear of Queue: " + queue.Rear);
                Console.WriteLine("\tThe number of jobs in the queue: " + queue.Count);
                Console.WriteLine("\tPlease select your choice and enter values 1-6 \n\n\t1) To add jobs to the queue \n\n\t2) To remove jobs from the queue \n\n\t3) To check the next job in the queue \n\n\t4) To count the number of jobs in the queue \n\n\t5) To clear the queue \n\n\t6)To check job availability of the job\n\n");
                int caseSwitch = GetChoice();
                if (caseSwitch < 0 && caseSwitch > 6)
                {
                    Console.WriteLine("Please enter only int values, enter number 1-6");
                }

                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("\tPlease enter Jobes to add in the Queue:");
                        int value = 0;
                        if(!int.TryParse(Console.ReadLine(), out value))
                        {
                            Console.WriteLine("Provided value isn't type of generic parameter.");
                            break;
                        }
                        queue.Enqueue(value);
                        Console.WriteLine("\tFront: " + queue.Front);
                        Console.WriteLine("\tRear: " + queue.Rear);
                        break;
                    case 2:
                        Console.WriteLine("\tYour removed job is  " + queue.Dequeue());
                        Console.WriteLine("\tFront: " + queue.Front);
                        break;
                    case 3:
                        Console.WriteLine("\tNext Job in the Queue is: " + queue.PeekQueue());
                        break;
                    case 4:
                        Console.WriteLine("\tThe number of jobs in the queue: " + queue.Count);
                        break;
                    case 5:
                        Console.WriteLine("\tthe queue is clear .");
                        queue.Clear();
                        break;
                    case 6:
                        Console.WriteLine("\tTo check job availability enter job:");
                        if (!int.TryParse(Console.ReadLine(), out value))
                        {
                            Console.WriteLine("Provided value isn't type of generic parameter.");
                            break;
                        }
                        if (queue.Contains(value))
                        {
                            Console.WriteLine(value + " job is available in the Queue.");
                        }
                        else
                        {
                            Console.WriteLine(value + " job is not available in the Queue.");
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter only int values, enter number 1-6");
                        break;
                }
                Console.WriteLine("Please press 'Y' to perform more actions else press any other key.");
                answer = Console.ReadLine().ToUpper();
            } while (answer == "Y");
        }

        private static void QueueOperation()
        {
            string answer = null;
            Queue queue = new Queue();

            do
            {
                Console.WriteLine("\tFront of Queue: " + queue.Front);
                Console.WriteLine("\tRear of Queue: " + queue.Rear);
                Console.WriteLine("\tThe number of jobs in the queue: " + queue.Count);
                Console.WriteLine("\tPlease select your choice and enter values 1-6 \n\n\t1) To add jobs to the queue \n\n\t2) To remove jobs from the queue \n\n\t3) To check the next job in the queue \n\n\t4) To count the number of jobs in the queue \n\n\t5) To clear the queue \n\n\t6)To check job availability of the job\n\n");
                int caseSwitch = GetChoice();
                if (caseSwitch < 0 && caseSwitch > 6)
                {
                    Console.WriteLine("Please enter only int values, enter number 1-6");
                }

                switch (caseSwitch)
                {
                    case 1:
                        Console.WriteLine("\tPlease enter Jobes to add in the Queue:");
                        queue.Enqueue(Console.ReadLine());
                        Console.WriteLine("\tFront: " + queue.Front);
                        Console.WriteLine("\tRear: " + queue.Rear);
                        break;
                    case 2:
                        Console.WriteLine("\tYour removed job is  " + queue.Dequeue());
                        Console.WriteLine("\tFront: " + queue.Front);
                        break;
                    case 3:
                        Console.WriteLine("\tNext Job in the Queue is: " + queue.PeekQueue());
                        break;
                    case 4:
                        Console.WriteLine("\tThe number of jobs in the queue: " + queue.Count);
                        break;
                    case 5:
                        Console.WriteLine("\tthe queue is clear .");
                        queue.Clear();
                        break;
                    case 6:
                        Console.WriteLine("\tTo check job availability enter job:");
                        String job = Console.ReadLine();
                        if (queue.Contains(job))
                        {
                            Console.WriteLine(job + " job is available in the Queue.");
                        }
                        else
                        {
                            Console.WriteLine(job + " job is not available in the Queue.");
                        }
                        break;
                    default:
                        Console.WriteLine("Please enter only int values, enter number 1-6");
                        break;
                }
                Console.WriteLine("Please press 'Y' to perform more actions else press any other key.");
                answer = Console.ReadLine().ToUpper();
            } while (answer == "Y");
        }

        private static int GetChoice()
        {
            int choices = 0;
            int.TryParse(Console.ReadLine(), out choices);
            return choices;
        }
    }
}
