using System;
class SpecificWord
{
    public static bool FindWord(string[]str,string word)
        {
            foreach (string s in str)
            {
                if(s==word)
                    return true;
            }
            return false;
        }
        public static void Main()
        {
            Console.Write("Enter Size of Array : ");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] str = new string[n];
            for (int i = 0; i < n; i++)
                str[i] = Console.ReadLine();

            Console.Write("Enter string to search : ");
            string word = Console.ReadLine();

            bool isFound = FindWord(str,word);
            Console.WriteLine($"Word found? : {isFound}");
        }

}