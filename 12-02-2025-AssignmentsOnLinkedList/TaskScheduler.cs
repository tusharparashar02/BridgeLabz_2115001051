using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class TaskScheduler
    {
        public int TaskID;
        public string TaskName;
        public int Priority;
        public string DueDate;
        public TaskScheduler Next;
        public TaskScheduler(int taskID, string taskName, int priority, string dueDate)
        {
            TaskID = taskID;
            TaskName = taskName;
            Priority = priority;
            DueDate = dueDate;
        }
    }
    class TaskLinkedList
    {
        private TaskScheduler head;
        private TaskScheduler current;

        public void AddTaskAtBeginning(int taskID, string taskName, int priority, string dueDate)
        {
            TaskScheduler newTask = new TaskScheduler(taskID, taskName, priority, dueDate);
            if (head == null)
            {
                head = newTask;
                head.Next = head;
                current = head;
            }
            else
            {
                TaskScheduler temp = head;
                while (temp.Next != head)
                    temp = temp.Next;
                temp.Next = newTask;
                newTask.Next = head;
                head = newTask;
            }
        }

        public void AddTaskAtEnd(int taskID, string taskName, int priority, string dueDate)
        {
            TaskScheduler newTask = new TaskScheduler(taskID, taskName, priority, dueDate);
            if (head == null)
            {
                head = newTask;
                head.Next = head;
                current = head;
            }
            else
            {
                TaskScheduler temp = head;
                while (temp.Next != head)
                    temp = temp.Next;
                temp.Next = newTask;
                newTask.Next = head;
            }
        }

        public void RemoveTask(int taskID)
        {
            if (head == null) return;

            TaskScheduler temp = head, prev = null;
            while (temp.Next != head)
            {
                if (temp.TaskID == taskID)
                {
                    if (prev != null)
                        prev.Next = temp.Next;
                    else
                    {
                        TaskScheduler last = head;
                        while (last.Next != head)
                            last = last.Next;
                        head = temp.Next;
                        last.Next = head;
                    }
                    return;
                }
                prev = temp;
                temp = temp.Next;
            }
        }

        public void ViewCurrentTask()
        {
            if (current != null)
            {
                Console.WriteLine($"Current Task: {current.TaskID}, {current.TaskName}");
            }
        }

        public void MoveToNextTask()
        {
            if (current != null)
            {
                current = current.Next;
                ViewCurrentTask();
            }
        }

        public void DisplayTasks()
        {
            if (head == null) return;
            TaskScheduler temp = head;
            while (temp.Next != head)
            {
                Console.Write($"{temp.TaskName}->");
                temp = temp.Next;
            }
            Console.WriteLine($"{temp.TaskName}");
        }

        public void SearchTaskByPriority(int priority)
        {
            if (head == null) return;
            TaskScheduler temp = head;
            while (temp.Next != head)
            {
                if (temp.Priority == priority)
                {
                    Console.WriteLine($"Task ID: {temp.TaskID}, Name: {temp.TaskName}");
                }
                temp = temp.Next;
            }
            if (temp.Priority == priority)
            {
                Console.WriteLine($"Task ID: {temp.TaskID}, Name: {temp.TaskName}");
            }
        }

        public static void Main3()
        {
            TaskLinkedList scheduler = new TaskLinkedList();
            scheduler.AddTaskAtBeginning(1, "Task 1", 2, "Today");
            scheduler.AddTaskAtEnd(2, "Task 2", 1, "Tomorrow");
            scheduler.AddTaskAtEnd(3, "Task 3", 3, "Yesterday");

            Console.WriteLine("All Tasks:");
            scheduler.DisplayTasks();

            Console.WriteLine("\nCurrent Task:");
            scheduler.ViewCurrentTask();

            Console.WriteLine("\nMoving to Next Task:");
            scheduler.MoveToNextTask();

            Console.WriteLine("\nSearch by Priority 1:");
            scheduler.SearchTaskByPriority(1);

            Console.WriteLine("\nRemoving Task 2:");
            scheduler.RemoveTask(2);
            scheduler.DisplayTasks();
        }
    }
}

