
using System;
using System.Collections.Generic;

class SocialMedia
{
    public int Id, Age;
    public string Name;
    public List<int> Friends;
    
    public SocialMedia Next;
    
    public SocialMedia(int id, string name, int age)
    {
        Id = id;
        Name = name;
        
        Age = age;
        
        Friends = new List<int>();
        
        Next = null;
    }
}

class SocialLinkedList
{
    private SocialMedia head;
    
    public void AddUser(int id, string name, int age)
    {
        SocialMedia newUser = new SocialMedia(id, name, age);
        
        newUser.Next = head;
        
        head = newUser;
    }
    
    public void AddFriend(int id1, int id2)
    {
        SocialMedia user1 = FindUser(id1);
        
        SocialMedia user2 = FindUser(id2);
        
        if (user1 != null && user2 != null && id1 != id2)
        {
            user1.Friends.Add(id2);
            
            user2.Friends.Add(id1);
        }
    }
    
    public void RemoveFriend(int id1, int id2)
    {
        SocialMedia user1 = FindUser(id1);
        
        SocialMedia user2 = FindUser(id2);
        
        if (user1 != null && user2 != null)
        {
            user1.Friends.Remove(id2);
            
            user2.Friends.Remove(id1);
        }
    }
    
    public void FindMutualFriends(int id1, int id2)
    {
        SocialMedia user1 = FindUser(id1);
        
        SocialMedia user2 = FindUser(id2);
        if (user1 != null && user2 != null)
        {
            List<int> mutual = new List<int>(user1.Friends);
            
            mutual = mutual.FindAll(id => user2.Friends.Contains(id));
            
            Console.WriteLine("Mutual Friends: " + string.Join(", ", mutual));
        }
    }
    
    public void DisplayFriends(int id)
    {
        SocialMedia user = FindUser(id);
        if (user != null)
            Console.WriteLine("Friends of " + user.Name + ": " + string.Join(", ", user.Friends));
    }
    
    public void SearchUser(int id, string name = "")
    {
        SocialMedia temp = head;
        while (temp != null)
        {
            if (temp.Id == id || temp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                Console.WriteLine("ID: " + temp.Id + ", Name: " + temp.Name + ", Age: " + temp.Age);
            temp = temp.Next;
        }
    }
    
    public void CountFriends()
    {
        SocialMedia temp = head;
        
        while (temp != null)
        {
            Console.WriteLine(temp.Name + " has " + temp.Friends.Count + " friends.");
            
            temp = temp.Next;
        }
    }
    
    private SocialMedia FindUser(int id)
    {
        SocialMedia temp = head;
        while (temp != null)
        {
            if (temp.Id == id) return temp;
            
            temp = temp.Next;
        }
        return null;
    }
    
    static void Main()
    {
        SocialLinkedList network = new SocialLinkedList();
        network.AddUser(1, "Tushar", 18);
        
        network.AddUser(2, "Parashar", 38);
        
        network.AddUser(3, "GLA", 55);
        
        network.AddFriend(1, 2);
        
        network.AddFriend(1, 3);
        
        
        Console.WriteLine("Displaying Friends:");
        
        network.DisplayFriends(1);
        network.DisplayFriends(2);
        
        Console.WriteLine("Finding Mutual Friends between 1 and 2:");
        
        network.FindMutualFriends(1, 2);
        
        
        Console.WriteLine("Counting Friends:");
        network.CountFriends();
    }
}
