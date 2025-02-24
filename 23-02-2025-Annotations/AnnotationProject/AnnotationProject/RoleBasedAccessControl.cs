using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationProject
{
    //RoleAllowed attribute
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    class RoleAllowedAttribute : Attribute
    {
        public string Role { get; }

        public RoleAllowedAttribute(string role)
        {
            Role = role;
        }
    }

    //Simulating a user with a role
    class User1
    {
        public string Role { get; }

        public User1(string role)
        {
            Role = role;
        }
    }

    //Applying RoleAllowed attribute to restrict access
    class SecureActions
    {
        [RoleAllowed("ADMIN")]
        public void AdminTask()
        {
            Console.WriteLine("Admin task executed successfully!");
        }

        [RoleAllowed("USER")]
        public void UserTask()
        {
            Console.WriteLine("User task executed successfully!");
        }
    }
    class RoleBasedAccessControl
    {
        static void ExecuteIfAuthorized(User1 user, object obj, string methodName)
        {
            MethodInfo method = obj.GetType().GetMethod(methodName);
            var attribute = (RoleAllowedAttribute)Attribute.GetCustomAttribute(method, typeof(RoleAllowedAttribute));

            if (attribute != null && attribute.Role == user.Role)
            {
                method.Invoke(obj, null); // Execute method
            }
            else
            {
                Console.WriteLine($"Access Denied! {user.Role} cannot execute {methodName}.");
            }
        }

        public static void Main()
        {
            User1 adminUser = new User1("ADMIN");
            User1 normalUser = new User1("USER");

            SecureActions actions = new SecureActions();

            Console.WriteLine("Trying with ADMIN user:");
            ExecuteIfAuthorized(adminUser, actions, "AdminTask"); // Should execute

            Console.WriteLine("\nTrying with USER:");
            ExecuteIfAuthorized(normalUser, actions, "AdminTask"); // Should be denied

            Console.WriteLine("\nTrying USER task with USER role:");
            ExecuteIfAuthorized(normalUser, actions, "UserTask"); // Should execute
        }
    }
}

