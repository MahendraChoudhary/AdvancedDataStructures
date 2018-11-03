using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace DataStructure
{
    internal class GenericQueue<T>
    {
        T front, rear;
        private List<T> jobList;
        private object syncRoot = new object();

        /*************************************************************************************
        About: This function a consructor of Queue class use to initialize instance variables.
        *************************************************************************************/
        internal GenericQueue()
        {
            jobList = new List<T>();
            this.front = rear = default(T);
        }

        internal T Front => front;

        internal T Rear => rear;

        internal int Count => jobList.Count;

        /*************************************************************************************
        About: This program takes jobs as input and return boolean of existing in Queue.
        *************************************************************************************/
        internal bool Contains(T job)
        {
            return jobList.Contains(job);
        }

        /*************************************************************************************
        About: This program takes given data as input and add this data added at rear position
        in Queue.
        *************************************************************************************/
        internal void Enqueue(T job)
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
        internal T Dequeue()
        {
            lock (this.syncRoot)
            {
                T job = default(T);
                if (this.jobList.Count == 0)
                {
                    Console.WriteLine("The queue is empty.");
                    return job;
                }

                job = this.jobList[0];
                this.jobList.RemoveAt(0);
                if (jobList.Count == 0)
                    front = rear = default(T);
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

                return this.jobList.LastOrDefault();
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
