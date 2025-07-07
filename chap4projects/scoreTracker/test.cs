using System;

namespace RoleSystem
{
    // Enum representing user roles
    public enum UserRole
    {
        Guest = 0,
        Student = 1,
        Teacher = 2,
        Admin = 3
    }

    public class User
    {
        public string Username { get; set; }
        public UserRole Role { get; set; }

        public User(string username, UserRole role)
        {
            Username = username;
            Role = role;
        }

        public void ShowDashboard()
        {
            Console.WriteLine($"\nWelcome, {Username}! You are logged in as a {Role}.");
            switch (Role)
            {
                case UserRole.Guest:
                    Console.WriteLine("Limited access: View-only content.");
                    break;
                case UserRole.Student:
                    Console.WriteLine("Access to course materials and assignments.");
                    break;
                case UserRole.Teacher:
                    Console.WriteLine("Access to course creation and grading tools.");
                    break;
                case UserRole.Admin:
                    Console.WriteLine("Full system access and configuration tools.");
                    break;
            }
        }
    }

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter your username:");
            string? username = Console.ReadLine();

            Console.WriteLine("Select role: 0 = Guest, 1 = Student, 2 = Teacher, 3 = Admin");
            if (!int.TryParse(Console.ReadLine(), out int roleValue) || !Enum.IsDefined(typeof(UserRole), roleValue))
            {
                Console.WriteLine("Invalid role. Defaulting to Guest.");
                roleValue = 0;
            }

            UserRole selectedRole = (UserRole)roleValue;
            User user = new User(username ?? "Anonymous", selectedRole);
            user.ShowDashboard();
        }
    }
}
