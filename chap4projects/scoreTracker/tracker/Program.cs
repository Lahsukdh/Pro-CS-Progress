using tracker;
using System.Linq;
using System.Security.Cryptography;
using System.ComponentModel;
using System.Transactions;
class Tracker
{
    static void Main()
    {
        string[] uNames = { "test", "cake", "water", "school" };
        string[] pWords = { "test2", "cake2", "water2", "school2" };

        System.Console.WriteLine("Enter Your Teacher Credentials");

        while (true)
        {
            System.Console.Write("Username: ");
            string? userName = Console.ReadLine();
            System.Console.Write("Password: ");
            string? passWord = Console.ReadLine();

            if (uNames.Contains(userName) && pWords.Contains(passWord))
            {
                break;
            }
            else
            {
                System.Console.WriteLine("Incorrect Credentials try again");
            }
        }
        Class class1 = new Class();
        class1.addStudent("Bob", 91);
        class1.addStudent("Maria", 90);
        class1.addStudent("Choji", 50);
        class1.viewClass();

        string? cmd;
        System.Console.WriteLine();
        System.Console.WriteLine("View | Average | Add | Remove | Exit");
        while (true)
        {
            System.Console.Write(">");
            cmd = Console.ReadLine();
            switch (cmd)
            {
                case "view":
                    class1.viewClass();
                    break;
                case "average":
                    class1.getAverage();
                    break;
                case "add":
                    System.Console.WriteLine("Enter the new student's name and grade");
                    System.Console.Write("Name: ");
                    string? tempName = Console.ReadLine();
                    System.Console.Write("Grade: ");
                    if (!(float.TryParse(Console.ReadLine(), out float res)))
                    {
                        System.Console.WriteLine("invalid grade");
                    }
                    else
                    {
                        class1.addStudent(tempName, res);
                    }
                    break;
                case "remove":
                    System.Console.WriteLine("Enter name of student to remove: ");
                    string? name = Console.ReadLine();
                    class1.removeStudent(name);
                    break;
                case "exit":
                    return;
                default:
                    System.Console.WriteLine("Not a valid command");
                    break;
            }
        }
    }
}