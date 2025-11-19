namespace LibSys
{
    using LibSys.Domain.User;
    using LibSys.Persistance;

    using System;
    using System.Reflection.Metadata;

    class Program
    {
        public static Library lib { get; set; }
        public static void Main(string[] args)
        {

            lib = new Library(new TestDataProvider());

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