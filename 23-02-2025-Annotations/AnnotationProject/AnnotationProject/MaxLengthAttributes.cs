using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AnnotationProject
{
    //MaxLength attribute
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    class MaxLengthAttributes : Attribute
    {
        public int Length { get; }

        public MaxLengthAttributes(int length)
        {
            Length = length;
        }
    }
    //Applying the attribute to a class field (Username)
    class User
    {
        [MaxLengthAttributes(10)]
        public string Username { get; }

        public User(string username)
        {
            ValidateMaxLength(this, nameof(Username), username);
            Username = username;
        }

        private void ValidateMaxLength(object obj, string propertyName, string value)
        {
            PropertyInfo property = obj.GetType().GetProperty(propertyName);
            var attribute = (MaxLengthAttributes)Attribute.GetCustomAttribute(property, typeof(MaxLengthAttributes));

            if (attribute != null && value.Length > attribute.Length)
            {
                throw new ArgumentException($"Error: {propertyName} cannot exceed {attribute.Length} characters.");
            }
        }
    }

    class MaxLengthAttribute
    {
        public static void Main()
        {
            try
            {
                User user1 = new User("Abcdefg");
                Console.WriteLine($"User created: {user1.Username}");

                User user2 = new User("Abcdefghijklmnopq");
                Console.WriteLine($"User created: {user2.Username}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
