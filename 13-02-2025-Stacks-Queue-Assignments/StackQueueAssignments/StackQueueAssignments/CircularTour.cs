using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueAssignments
{
    internal class CircularTour
    {
            private int[] data;
            private int front, rear, size, capacity;

            public CircularTour(int capacity)
            {
                this.capacity = capacity;
                data = new int[capacity];
                front = 0;
                rear = -1;
                size = 0;
            }

            public void Enqueue(int value)
            {
                if (size == capacity)
                {
                    Console.WriteLine("out of Capacity");
                    return;
                }
                rear = (rear + 1) % capacity;
                data[rear] = value;
                size++;
            }

            public int Dequeue()
            {
                if (size == 0)
                {
                    Console.WriteLine("Queue empty");
                    return -1;
                }
                int value = data[front];
                front = (front + 1) % capacity;
                size--;
                return value;
            }

            public int Front()
            {
                return data[front];
            }

            public bool IsEmpty()
            {
                return size == 0;
            }

            public int Size()
            {
                return size;
            }
        }

        class CircularTourQueue
        {
            public static int FindStartingPoint(int[] petrol, int[] distance)
            {
                int n = petrol.Length;
            CircularTour queue = new CircularTour(n);

                int total = 0;
                int current = 0;
                int start = 0;

                for (int i = 0; i < n; i++)
                {
                    int balance = petrol[i] - distance[i];
                    total += balance;
                    current += balance;

                    queue.Enqueue(i);

                    // If we run out of petrol, remove pumps from the queue
                    while (current < 0 && !queue.IsEmpty())
                    {
                        int removedIndex = queue.Dequeue();
                        current -= petrol[removedIndex] - distance[removedIndex];
                        start = removedIndex + 1;
                    }
                }

                return total >= 0 ? start : -1;
            }

            public static void Main()
            {
                int[] petrol = { 2, 3, 4, 5 };
                int[] distance = { 6, 5, 4, 3 };

                int start = FindStartingPoint(petrol, distance);

                Console.WriteLine(start == -1 ? "No circular tour possible" : "Start at petrol pump: " + start);
            }
        }
    }
}
