using System;
using System.Collections.Generic;

class UndoRedo
{
    public string Content;
    public UndoRedo Prev, Next;
    
    public UndoRedo(string content)
    {
        Content = content;
        
        Prev = Next = null;
    }
}

class UndoRedoLinkedList
{
    private UndoRedo current;
    private int maxHistory = 10;
    
    private int historyCount = 0;
    
    public void AddState(string content)
    {
        UndoRedo newState = new UndoRedo(content);
        if (current != null)
        {
            newState.Prev = current;
            
            current.Next = newState;
        }
        current = newState;
        
        historyCount++;
        
        if (historyCount > maxHistory)
        {
            UndoRedo temp = current;
            while (temp.Prev != null && historyCount > maxHistory)
            {
                temp = temp.Prev;
                
                temp.Next = null;
                
                historyCount--;
            }
        }
    }
    
    public void Undo()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
            
            Console.WriteLine("Undo: " + current.Content);
        }
        else
            Console.WriteLine("No more undo available.");
    }
    
    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
            
            Console.WriteLine("Redo: " + current.Content);
        }
        else
            Console.WriteLine("No more redo available.");
    }
    
    public void DisplayCurrent()
    {
        if (current != null)
            Console.WriteLine("Current State: " + current.Content);
        else
            Console.WriteLine("No content available.");
    }
    
    static void Main()
    {
        UndoRedoLinkedList tryit = new UndoRedoLinkedList();
        tryit.AddState("Namaste");
        
        tryit.AddState("Namaste Bharat");
        
        tryit.AddState("Hello Bharat");
        
        Console.WriteLine("Displaying Current State:");
        
        tryit.DisplayCurrent();
        
        Console.WriteLine("Performing Undo:");
        
        tryit.Undo();
        
        Console.WriteLine("Performing Redo:");
        
        tryit.Redo();
    }
}