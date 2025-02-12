using System;

class RoundRobin
{
    public int Id, Burst, Priority;
    public ProcessNode Next;
    
    public ProcessNode(int id, int burst, int priority)
    {
        Id = id;
        Burst = burst;
        
        Priority = priority;
        Next = null;
    }
}

class RoundRobinLinkedList
{
    private ProcessNode head, tail;
    private int timeQuantum;
    
    public RoundRobinLinkedList(int quantum)
    {
        timeQuantum = quantum;
        
        head = tail = null;
    }
    
    public void AddProcess(int id, int burst, int priority)
    {
        ProcessNode newProcess = new ProcessNode(id, burst, priority);
        if (head == null)
        {
            head = tail = newProcess;
            
            tail.Next = head;
        }
        else
        {
            tail.Next = newProcess;
            
            tail = newProcess;
            
            tail.Next = head;
        }
    }

    public void RemoveProcess(int id)
    {
        if (head == null) return;
        
        ProcessNode temp = head, prev = null;
        do
        {
            if (temp.Id == id)
            {
                if (temp == head)
                {
                    head = head.Next;
                    
                    tail.Next = head;
                }
                else if (temp == tail)
                {
                    tail = prev;
                    
                    tail.Next = head;
                }
                else
                    prev.Next = temp.Next;
                return;
            }
            prev = temp;
            
            temp = temp.Next;
            
        } while (temp != head);
    }
    
    public void ExecuteSchedule()
    {
        if (head == null) return;
        
        int totalTime = 0, waitTime = 0, turnaroundTime = 0, processCount = 0;
        
        ProcessNode temp = head;
        
        while (head != null)
        {
            if (temp.Burst > timeQuantum)
            {
                temp.Burst -= timeQuantum;
                
                totalTime += timeQuantum;
                
                temp = temp.Next;
            }
            else
            {
                totalTime += temp.Burst;
                
                turnaroundTime += totalTime;
                
                waitTime += totalTime - temp.Burst;
                
                RemoveProcess(temp.Id);
                temp = head;
                processCount++;
            }
            DisplayProcesses();
        }
        Console.WriteLine("Average Waiting Time: " + (double)waitTime / processCount);
        
        Console.WriteLine("Average Turnaround Time: " + (double)turnaroundTime / processCount);
    }
    
    public void DisplayProcesses()
    {
        if (head == null) return;
        
        
        ProcessNode temp = head;
        do
        {
            Console.WriteLine("ID: " + temp.Id + ", Burst: " + temp.Burst + ", Priority: " + temp.Priority);
            temp = temp.Next;
        } while (temp != head);
        
        Console.WriteLine();
    }
    
    static void Main()
    {
        RoundRobinLinkedList scheduler = new RoundRobinLinkedList(4);
        scheduler.AddProcess(1, 8, 3);
        
        scheduler.AddProcess(2, 7, 2);
        
        scheduler.AddProcess(3, 6, 1);
        
        Console.WriteLine("Initial Process List:");
        
        scheduler.DisplayProcesses();
        
        Console.WriteLine("Executing Round Robin Scheduling:");
        
        scheduler.ExecuteSchedule();
        
    }
}