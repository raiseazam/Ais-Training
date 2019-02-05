using System;
using System.Collections;
using System.Collections.Generic;
namespace QueueTest
{
    public  class Program
    {
        
         void EnQ(Queue<int> q ,int element)
        {
            q.Enqueue(element);
        }
         int DeQ(Queue<int> q)
        {
            if (q.Count==0)
                return -1;
            return q.Dequeue();
        }
        int AtFront(Queue<int> q)
        {
            if (q.Count == 0)
                return -1;
            return q.Peek();
        }
        static void Main(string[] args)
        {

            Program obj = new Program();
            Queue<int> q = new Queue<int>();
            try
            {
                while (true)
                {
                    int flag = -1;
                    Console.WriteLine("\n \n \nEnter 1 for Enqueuing value in queue :");
                    Console.WriteLine("Enter 2 for dequeuing value from queue :");
                    Console.WriteLine("Enter 3 for fetching value from the front of the queue :");
                    Console.WriteLine("Enter 4 for stopping all kind of queue operation or EXIT:");
                    int caseSwitch = Convert.ToInt32(Console.ReadLine());
                    switch (caseSwitch)
                    {
                        case 1:
                            flag = 1;
                            Console.WriteLine("Enter value to be enqueued");
                            int val = Convert.ToInt32(Console.ReadLine());
                            obj.EnQ(q, val);
                            break;
                        case 2:
                            flag = 2;
                            int del = obj.DeQ(q);
                            if (del == -1)
                                Console.WriteLine("Queue is Empty...... Nothing To Dequeue");
                            else
                                Console.WriteLine("Element dequeued from the front of the queue is :" + del);
                            break;
                        case 3:
                            flag = 3;
                            int t = obj.AtFront(q);
                            if (t == -1)
                                Console.WriteLine("Queue is Empty ...  Nothing to print :");
                            else
                                Console.WriteLine("Value at the front of the Queue is :" + t);
                            break;
                        case 4:
                            flag = 4;
                            break;
                        default:
                            Console.WriteLine("Wrong key pressed .....");
                            break;
                    }
                    if (flag == 4)
                        break;
                    else
                        continue;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }


        }
    }
}


