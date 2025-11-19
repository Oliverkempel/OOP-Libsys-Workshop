namespace LibSys
{
    using LibSys.Domain.Media;
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


            while(lib.currentUser == null)
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
            
            Console.WriteLine("Welcome to the gooner library!");
            Console.WriteLine("====================[ List of media in lib ]====================");
            foreach(Media media in lib.Medias)
            {
                Console.WriteLine(media.getDesc());
            }

        }

        public void drawList()
        {

        }
    }
}