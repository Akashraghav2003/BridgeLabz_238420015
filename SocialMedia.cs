using System;
using System.Collections.Generic;

class User
{
    public int UserID { get; set; } // Unique User ID
    public string Name { get; set; } // User's Name
    public int Age { get; set; } // User's Age
    public List<int> Friends { get; set; } // List of Friend IDs
    public User Next { get; set; } // Pointer to next user in the list

    public User(int userID, string name, int age)
    {
        UserID = userID;
        Name = name;
        Age = age;
        Friends = new List<int>();
        Next = null;
    }
}

class SocialMedia
{
    private User head; // Head of the singly linked list

    // Adds a new user to the system
    public void AddUser(int userID, string name, int age)
    {
        User newUser = new User(userID, name, age);
        if (head == null)
        {
            head = newUser;
        }
        else
        {
            User temp = head;
            while (temp.Next != null)
            {
                temp = temp.Next;
            }
            temp.Next = newUser;
        }
    }

    // Finds a user by User ID
    private User FindUser(int userID)
    {
        User temp = head;
        while (temp != null)
        {
            if (temp.UserID == userID)
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    // Adds a friend connection between two users
    public void AddFriend(int userID1, int userID2)
    {
        User user1 = FindUser(userID1);
        User user2 = FindUser(userID2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        if (!user1.Friends.Contains(userID2))
            user1.Friends.Add(userID2);

        if (!user2.Friends.Contains(userID1))
            user2.Friends.Add(userID1);

        Console.WriteLine($"{user1.Name} and {user2.Name} are now friends.");
    }

    // Removes a friend connection between two users
    public void RemoveFriend(int userID1, int userID2)
    {
        User user1 = FindUser(userID1);
        User user2 = FindUser(userID2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        user1.Friends.Remove(userID2);
        user2.Friends.Remove(userID1);

        Console.WriteLine($"{user1.Name} and {user2.Name} are no longer friends.");
    }

    // Finds and displays mutual friends between two users
    public void FindMutualFriends(int userID1, int userID2)
    {
        User user1 = FindUser(userID1);
        User user2 = FindUser(userID2);

        if (user1 == null || user2 == null)
        {
            Console.WriteLine("One or both users not found.");
            return;
        }

        List<int> mutualFriends = user1.Friends.FindAll(friendID => user2.Friends.Contains(friendID));

        if (mutualFriends.Count == 0)
        {
            Console.WriteLine("No mutual friends found.");
        }
        else
        {
            Console.Write("Mutual Friends: ");
            foreach (int id in mutualFriends)
            {
                User friend = FindUser(id);
                if (friend != null)
                    Console.Write(friend.Name + " ");
            }
            Console.WriteLine();
        }
    }

    // Displays all friends of a specific user
    public void DisplayFriends(int userID)
    {
        User user = FindUser(userID);

        if (user == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        Console.Write($"{user.Name}'s Friends: ");
        if (user.Friends.Count == 0)
        {
            Console.WriteLine("No friends.");
            return;
        }

        foreach (int friendID in user.Friends)
        {
            User friend = FindUser(friendID);
            if (friend != null)
                Console.Write(friend.Name + " ");
        }
        Console.WriteLine();
    }

    // Searches for a user by User ID or Name
    public void SearchUser(string query)
    {
        User temp = head;
        bool found = false;

        while (temp != null)
        {
            if (temp.Name.Equals(query, StringComparison.OrdinalIgnoreCase) || temp.UserID.ToString() == query)
            {
                Console.WriteLine($"User Found: ID={temp.UserID}, Name={temp.Name}, Age={temp.Age}");
                found = true;
            }
            temp = temp.Next;
        }

        if (!found)
            Console.WriteLine("User not found.");
    }

    // Counts and displays the number of friends for each user
    public void CountFriends()
    {
        User temp = head;

        while (temp != null)
        {
            Console.WriteLine($"{temp.Name} has {temp.Friends.Count} friends.");
            temp = temp.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        SocialMedia sm = new SocialMedia();

        // Adding users
        sm.AddUser(1, "Alice", 25);
        sm.AddUser(2, "Bob", 30);
        sm.AddUser(3, "Charlie", 28);
        sm.AddUser(4, "David", 27);

        // Adding friends
        sm.AddFriend(1, 2);
        sm.AddFriend(1, 3);
        sm.AddFriend(2, 4);

        // Displaying friends
        sm.DisplayFriends(1);
        sm.DisplayFriends(2);

        // Finding mutual friends
        sm.FindMutualFriends(1, 2);

        // Searching for a user
        sm.SearchUser("Charlie");
        sm.SearchUser("3");

        // Counting number of friends for each user
        sm.CountFriends();

        // Removing a friend
        sm.RemoveFriend(1, 2);
        sm.DisplayFriends(1);
        sm.DisplayFriends(2);
    }
}