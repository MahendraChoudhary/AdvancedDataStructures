using System;
using System.Collections;
using System.Collections.Generic;

namespace DataStructure
{
    internal class GenericStack<T>
    {
        T top;
        private List<T> jobList;
        private object syncRoot = new object();

        /*************************************************************************************
        About: This function a consructor of Stack class use to initialize instance variables.
        *************************************************************************************/
        internal GenericStack()
        {
            jobList = new List<T>();
            this.top = default(T);
        }

        internal T Top => top;

        internal int Count => jobList.Count;

        /*************************************************************************************
        About: This program takes jobs as input and return boolean of existing in Stack.
        *************************************************************************************/
        internal bool Contains(T job)
        {
            return jobList.Contains(job);
        }

        /*************************************************************************************
        About: This program takes given data as input and add this data added at top position
        in Stack.
        *************************************************************************************/
        internal void Push(T job)
        {
            lock (this.syncRoot)
            {
                this.top = job;
                this.jobList.Add(job);

                Console.WriteLine("A job added in stack.");
            }
        }

        /*************************************************************************************
        About: This program is removed from last position element from Stack
        *************************************************************************************/
        internal T Pop()
        {
            lock (this.syncRoot)
            {
                T job = default(T);
                if (this.jobList.Count == 0)
                {
                    Console.WriteLine("The stack is empty.");
                    return job;
                }
                
                this.jobList.RemoveAt(jobList.Count-1);
                if (jobList.Count == 0)
                    top = default(T);
                else
                    top = jobList[jobList.Count - 1];

                Console.WriteLine("A job removed from Stack.");
                return job;
            }
        }

        /*************************************************************************************
        About: This program find the last element from the Stack
        *************************************************************************************/
        internal object Peek()
        {
            lock (this.syncRoot)
            {
                if (this.jobList.Count == 0)
                {
                    Console.WriteLine("The stack is empty.");
                    return null;
                }

                return this.jobList[jobList.Count - 1];
            }
        }

        /*************************************************************************************
        About: This program clears the elements from the Queue
        *************************************************************************************/
        internal void Clear()
        {
            jobList.Clear();
            Console.WriteLine("Stack is cleared");
        }
    }


}
