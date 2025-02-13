using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueAssignments
{
    internal class ImplementQueue
    {
        public int Data;
        public ImplementQueue Next;

        public ImplementQueue(int data)
        {
            Data = data;
        }
    }
    class QueueUsingstack
    {
        private ImplementQueue top;

        public void Push(int data)
        {
            ImplementQueue newData = new ImplementQueue(data);

            if (top == null)
            {
                top = newData;
                return;
            }

            newData.Next = top;
            top = newData;
        }

        public ImplementQueue Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is Empty");
                return null;
            }
            ImplementQueue temp = top;
            top = top.Next;
            temp.Next = null;

            return temp;
        }

        public int Peek()
        {
            return top != null ? top.Data : -1;
        }

        public int Count(int data)
        {
            int count = 0;
            if (top == null)
                return 0;

            ImplementQueue temp = top;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void PrintStack()
        {
            ImplementQueue temp = top;
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
            Console.WriteLine();
        }
    }

    class QueueUsingStack
    {
        private UseStack enqueueStack = new UseStack();
        private UseStack dequeueStack = new UseStack();

        // Enqueue operation
        public void Enqueue(int data)
        {
            enqueueStack.Push(data);
        }

        // Dequeue operation 
        public int Dequeue()
        {
            if (dequeueStack.IsEmpty())
            {
                if (enqueueStack.IsEmpty())
                {
                    Console.WriteLine("Queue is Empty");
                    return -1;
                }

                // Transfer elements from enqueueStack to dequeueStack
                while (!enqueueStack.IsEmpty())
                {
                    dequeueStack.Push(enqueueStack.Pop().Data);
                }
            }
            return dequeueStack.Pop().Data;
        }

        // Peek operation
        public int Peek()
        {
            if (dequeueStack.IsEmpty())
            {
                if (enqueueStack.IsEmpty())
                {
                    Console.WriteLine("Queue is Empty");
                    return -1;
                }
                while (!enqueueStack.IsEmpty())
                {
                    dequeueStack.Push(enqueueStack.Pop().Data);
                }
            }
            return dequeueStack.Peek();
        }

        // Check if queue is empty
        public bool IsEmpty()
        {
            return enqueueStack.IsEmpty() && dequeueStack.IsEmpty();
        }
        public static void Main1()
        {
            QueueUsingStack queue = new QueueUsingStack();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Dequeue());

            queue.Enqueue(4);
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
        }
    }
}
