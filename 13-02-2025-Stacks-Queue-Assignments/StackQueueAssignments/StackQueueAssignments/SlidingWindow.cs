using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackQueueAssignments
{
    internal class SlidingWindow
    {
            private int[] data;
            private int front, rear, size;

            public SlidingWindow(int capacity)
            {
                data = new int[capacity];
                front = 0;
                rear = -1;
                size = 0;
            }

            public void AddLast(int value)
            {
                if (size == data.Length)
                {
                    Console.WriteLine("Out of Capacity");
                    return;
                }
                rear = (rear + 1) % data.Length;
                data[rear] = value;
                size++;
            }

            public void RemoveFirst()
            {
                if (size == 0)
                {
                    Console.WriteLine("Deque is Empty");
                    return;
                }

                front = (front + 1) % data.Length;
                size--;
            }

            public void RemoveLast()
            {
                if (size == 0)
                {
                    Console.WriteLine("Deque is Empty");
                    return;
                }

                rear = (rear - 1 + data.Length) % data.Length;
                size--;
            }

            public int First()
            {
                return data[front];
            }

            public int Last()
            {
                return data[rear];
            }

            public bool IsEmpty()
            {
                return size == 0;
            }
        }

        class SlidingWindowMax
        {
            public static int[] MaxSlidingWindow(int[] nums, int k)
            {
                if (nums.Length == 0 || k == 0)
                    return new int[0];

                int n = nums.Length;
                int[] result = new int[n - k + 1];
                int index = 0;

            SlidingWindow deque = new SlidingWindow(n);

                for (int i = 0; i < n; i++)
                {
                    // Remove elements from front if they are out of the window
                    if (!deque.IsEmpty() && deque.First() < i - k + 1)
                    {
                        deque.RemoveFirst();
                    }

                    // Remove elements from back if they are smaller than current element
                    while (!deque.IsEmpty() && nums[deque.Last()] <= nums[i])
                    {
                        deque.RemoveLast();
                    }

                    // Add current index to deque
                    deque.AddLast(i);

                    // Store the max for each window
                    if (i >= k - 1)
                    {
                        result[index++] = nums[deque.First()];
                    }
                }

                return result;
            }

            public static void Main4()
            {
                int[] nums = { 1, 2, -2, -3, 6, 4, 5 };
                int k = 3;

                int[] result = MaxSlidingWindow(nums, k);

                Console.Write("Sliding Window Maximum: ");
                foreach (int i in result)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
