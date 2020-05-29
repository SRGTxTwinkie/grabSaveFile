using System;
using System.IO;


namespace grabTerrariaSave
{
    class Program
    {

        static void Main(string[] args)
        {

            string username = Environment.UserName;
            string source_file_pull = $@"C:\Users\{username}\Documents\My Games\Terraria\Worlds\Jamie_Lee_Curtis.wld"; //Source File for pulling
            string source_file_push = $@"C:\Users\{username}\Desktop\Jamie_Lee_Curtis.wld"; //Source File for pushing
            string destination_file_pull = $@"C:\Users\{username}\Desktop\Jamie_Lee_Curtis.wld"; //Destination file for pulling
            string destination_file_push = $@"C:\Users\{username}\Documents\My Games\Terraria\Worlds\Jamie_Lee_Curtis.wld"; //Destination file for pushing

            Console.WriteLine("Do you want to pull or push the folder?");
            Console.WriteLine("Press enter to pull, or type \"2\" to push the folder to the worlds folder");
            if(Console.ReadLine() == "")
            {
                try
                {
                    File.Copy(source_file_pull, destination_file_pull, true);
                    Console.WriteLine("File pulled succesfully");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                catch (IOException iox)
                {
                    Console.WriteLine(iox);
                }
            }
            else
            {
                try
                {
                    File.Copy(source_file_push, destination_file_push, true);
                    Console.WriteLine("File pushed succesfully");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                catch (IOException iox)
                {
                    Console.WriteLine(iox);
                }
            }

        }
    }
}

