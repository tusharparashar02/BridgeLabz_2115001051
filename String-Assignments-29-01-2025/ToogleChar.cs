using System;
class ToogleChar
{
    static void Main(string[] args){
        Console.WriteLine("Enetr the String: ");
        string str = Console.ReadLine();
        string toogle = ToogleCharacter(str);
        Console.WriteLine("After Toogle each character the string is : "+ toogle);
    }
    static string ToogleCharacter(string str){
        char[] ch = str.ToCharArray();
        for (int i = 0; i < ch.Length; i++){
            if (char.IsUpper(ch[i])){
                ch[i] = char.ToLower(ch[i]);
            }
            else if (char.IsLower(ch[i])){
                ch[i] = char.ToUpper(ch[i]);
            }
        }
        return new string(ch);
    }
}