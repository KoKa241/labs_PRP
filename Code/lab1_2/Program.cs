using System;
using System.Collections.Generic;

class Program
{
    static List<object> group_list = new List<object>();
    static List<object> students = new List<object>();

    static void Main(string[] args)
    {
        InitializeGroups();
        InitializeStudents();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Show all students with their groups");
            Console.WriteLine("2. Show students of a specific group");
            Console.WriteLine("3. Add a student");
            Console.WriteLine("4. Remove a student");
            Console.WriteLine("5. Add a group");
            Console.WriteLine("6. Remove a group");
            Console.WriteLine("7. Exit");

            Console.Write("\nEnter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ShowAllStudentsWithGroups();
                    break;
                case 2:
                    ShowStudentsOfSpecificGroup();
                    break;
                case 3:
                    AddStudent();
                    break;
                case 4:
                    RemoveStudent();
                    break;
                case 5:
                    AddGroup();
                    break;
                case 6:
                    RemoveGroup();
                    break;
                case 7:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void InitializeGroups()
    {
        group_list.Add(new List<object> { "KI21-1", 1 });
        group_list.Add(new List<object> { "KI21-2", 2 });
        group_list.Add(new List<object> { "KI21-3", 3 });
        group_list.Add(new List<object> { "KI21-4", 4 });
        group_list.Add(new List<object> { "KI21-5", 5 });
    }

    static void InitializeStudents()
    {
        students.Add(new List<object> { 2, 1, "Vasyliev" });
        students.Add(new List<object> { 3, 2, "Klymenko" });
        students.Add(new List<object> { 4, 1, "Tereshenko" });
    }

    static void ShowAllStudentsWithGroups()
    {
        foreach (List<object> studentData in students)
        {
            int student_num = (int)studentData[0];
            int group_num = (int)studentData[1];
            string surname = (string)studentData[2];

            string groupName = GetGroupNameByNumber(group_num);

            Console.WriteLine($"{surname} {student_num} {groupName}");
        }
    }

    static void ShowStudentsOfSpecificGroup()
    {
        Console.Write("Enter group name: ");
        string groupName = Console.ReadLine();

        foreach (List<object> studentData in students)
        {
            int student_num = (int)studentData[0];
            int group_num = (int)studentData[1];
            string surname = (string)studentData[2];

            string group = GetGroupNameByNumber(group_num);

            if (group.Equals(groupName, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"{surname} {student_num}");
            }
        }
    }

    static void AddStudent()
    {
        Console.Write("Enter student number: ");
        int studentNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter group number: ");
        int groupNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter student surname: ");
        string surname = Console.ReadLine();

        students.Add(new List<object> { studentNumber, groupNumber, surname });
        Console.WriteLine("Student added successfully.");
    }

    static void RemoveStudent()
    {
        Console.Write("Enter student surname to remove: ");
        string surname = Console.ReadLine();

        for (int i = 0; i < students.Count; i++)
        {
            List<object> studentData = (List<object>)students[i];
            string studentSurname = (string)studentData[2];
            if (studentSurname.Equals(surname, StringComparison.OrdinalIgnoreCase))
            {
                students.RemoveAt(i);
                Console.WriteLine("Student removed successfully.");
                return;
            }
        }

        Console.WriteLine("Student not found.");
    }

    static void AddGroup()
    {
        Console.Write("Enter group name: ");
        string groupName = Console.ReadLine();

        Console.Write("Enter group number: ");
        int groupNumber = int.Parse(Console.ReadLine());

        group_list.Add(new List<object> { groupName, groupNumber });
        Console.WriteLine("Group added successfully.");
    }

    static void RemoveGroup()
    {
        Console.Write("Enter group name to remove: ");
        string groupName = Console.ReadLine();

        for (int i = 0; i < group_list.Count; i++)
        {
            List<object> groupData = (List<object>)group_list[i];
            string group = (string)groupData[0];
            if (group.Equals(groupName))
            {
                group_list.RemoveAt(i);
                Console.WriteLine("Group removed successfully.");
                return;
            }
        }

        Console.WriteLine("Group not found.");
    }

    static string GetGroupNameByNumber(int groupNumber)
    {
        foreach (List<object> groupData in group_list)
        {
            int num = (int)groupData[1];
            if (num == groupNumber)
            {
                return (string)groupData[0];
            }
        }
        return "Unknown";
    }
}
