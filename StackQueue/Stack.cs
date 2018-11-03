using System;
using System.Collections;

namespace DataStructure
{
    internal class Stack
    {
        object top;
        private ArrayList jobList;
        private object syncRoot = new object();

        /*************************************************************************************
        About: This function a consructor of Stack class use to initialize instance variables.
        *************************************************************************************/
        internal Stack()
        {
            jobList = new ArrayList();
            this.top = null;
        }

        internal object Top => top;

        internal int Count => jobList.Count;

        /*************************************************************************************
        About: This program takes jobs as input and return boolean of existing in Stack.
        *************************************************************************************/
        internal bool Contains(object job)
        {
            return jobList.Contains(job);
        }

        /*************************************************************************************
        About: This program takes given data as input and add this data added at top position
        in Stack.
        *************************************************************************************/
        internal void Push(object job)
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
        internal object Pop()
        {
            lock (this.syncRoot)
            {
                object job = null;
                if (this.jobList.Count == 0)
                {
                    Console.WriteLine("The stack is empty.");
                    return null;
                }
                
                this.jobList.RemoveAt(jobList.Count-1);
                if (jobList.Count == 0)
                    top = null;
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
