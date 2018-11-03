using System;
using System.Collections;
using System.Linq;

namespace DataStructure
{
    internal class Queue
    {
        object front, rear;
        private ArrayList jobList;
        private object syncRoot = new object();

        /*************************************************************************************
        About: This function a consructor of Queue class use to initialize instance variables.
        *************************************************************************************/
        internal Queue()
        {
            jobList = new ArrayList();
            this.front = rear = null;
        }

        internal object Front => front;

        internal object Rear => rear;

        internal int Count => jobList.Count;

        /*************************************************************************************
        About: This program takes jobs as input and return boolean of existing in Queue.
        *************************************************************************************/
        internal bool Contains(object job)
        {
            return jobList.Contains(job);
        }

        /*************************************************************************************
        About: This program takes given data as input and add this data added at rear position
        in Queue.
        *************************************************************************************/
        internal void Enqueue(object job)
        {
            lock (this.syncRoot)
            {
                if (jobList.Count == 0)
                    this.front = this.rear = job;
                else
                    this.rear = job;

                this.jobList.Add(job);

                Console.WriteLine("A job added in queue.");
            }
        }

        /*************************************************************************************
        About: This program is removed front position element from Queue
        *************************************************************************************/
        internal object Dequeue()
        {
            lock (this.syncRoot)
            {
                object job = null;
                if (this.jobList.Count == 0)
                {
                    Console.WriteLine("The queue is empty.");
                    return null;
                }

                job = this.jobList[0];
                this.jobList.RemoveAt(0);
                if (jobList.Count == 0)
                    front = rear = null;
                else
                    front = jobList[0];

                Console.WriteLine("A job removed from queue.");
                return job;
            }
        }

        /*************************************************************************************
        About: This program find the last element from the Queue
        *************************************************************************************/
        internal object PeekQueue()
        {
            lock (this.syncRoot)
            {
                if (this.jobList.Count == 0)
                {
                    Console.WriteLine("The queue is empty.");
                    return null;
                }

                return this.jobList[jobList.Count-1];
            }
        }

        /*************************************************************************************
        About: This program clears the elements from the Queue
        *************************************************************************************/
        internal void Clear()
        {
            jobList.Clear();
            Console.WriteLine("Queue is cleared");
        }
    }


}
