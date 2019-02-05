using System;
using System.Collections;
using System.Collections.Generic;
namespace StackWeek1
{
    public class Program
    {
         
         void Insert(int element,Stack<int> st)
        {
            st.Push(element);
        }
         int Del(Stack<int> st)
        {
            if (st.Count == 0)
                return -1;
            return st.Pop();
        }
         int AtTop(Stack<int> st)
        {
            if (st.Count == 0)
                return -1;
            return st.Peek();
        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            Stack<int> st = new Stack<int>();

            while (true)
            {
                int flag = -1;
                Console.WriteLine("\n \n \nEnter 1 for inserting value in stack :");
                Console.WriteLine("Enter 2 for deleting value from stack :");
                Console.WriteLine("Enter 3 for fetching value at the top of stack :");
                Console.WriteLine("Enter 4 for stopping all kind of stack operation or EXIT:");
                int caseSwitch = Convert.ToInt32(Console.ReadLine());
                switch (caseSwitch)
                {
                    case 1:
                        flag = 1;
                        Console.WriteLine("Enter value to be inserted in stack");
                        int val = Convert.ToInt32(Console.ReadLine());
                        obj.Insert(val,st);
                        break;
                    case 2:
                        flag = 2;
                        int del = obj.Del(st);
                        if(del==-1)
                        Console.WriteLine("Stack is Empty...... Nothing To pop");
                        else
                        Console.WriteLine("Element popped from the top of the stack is :"+del);
                        break;
                    case 3:
                        flag = 3;
                        int t= obj.AtTop(st);
                        if(t==-1)
                        Console.WriteLine("Stack is Empty ...  Nothing to print :");
                        else
                        Console.WriteLine("Value at the top of the stack is :"+t);
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
    }
}

