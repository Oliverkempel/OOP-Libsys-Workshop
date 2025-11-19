namespace LibSys
{
    using LibSys.Domain.User;

    using System;
    using System.Reflection.Metadata;

    class Program
    {
        public static Library lib { get; set; } = new Library();
        public static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Please enter username: ");
                string username = Console.ReadLine();
                bool loginSuccess = lib.login(username);

                if (loginSuccess)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Login successfull! [{lib.currentUser.Name}]");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Login unsuccessfull!");
                    Console.ResetColor();
                }
            }
            

        }
    }
}