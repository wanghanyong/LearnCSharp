using System;

namespace HolleWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region Work with strings
            string firstFriend = "Scott";
            string secondFriend = "Kendra";
            Console.WriteLine($"My friend are {firstFriend} and {secondFriend}");
            Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
            Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

            string greeting = "    Hello World    ";
            Console.WriteLine($"[{greeting}]");
            Console.WriteLine($"[{greeting.TrimStart()}]");
            Console.WriteLine($"[{greeting.TrimEnd()}]");
            Console.WriteLine($"[{greeting.Trim()}]");

            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            //Search strings
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
            #endregion

            #region Numbers in C#

            #endregion


            Console.Read();
        }
    }

}
