using System;

namespace FileManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            files file = new files();
            label:
            Console.WriteLine("Enter your choice..");
            Console.WriteLine("1.Create a File");
            Console.WriteLine("2.Display Contents of a File");
            Console.WriteLine("3.Concate Two Files");
            Console.WriteLine("4.Copy a File");
            Console.WriteLine("5.Rename a File");
            Console.WriteLine("6.Exit");
            int choice = Int32.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    
                    file.CreateFile();
                    Console.ReadKey();
                    goto label;

                case 2:
                    
                    file.OpenFile();
                    goto label;

                case 3:
                    file.Concate();
                    goto label;

                case 4:
                    file.copy();
                    goto label;

                case 5:
                    file.Rename();
                    goto label;

                case 6:
                    break;
            }
        }
    }
}
