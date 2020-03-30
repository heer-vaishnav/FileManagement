using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileManagement
{
    class files
    {
        public void CreateFile()
        {
            Console.Clear();
            Console.WriteLine("Enter your File Name");
            string fileName = Console.ReadLine();
            StreamWriter sw = new StreamWriter("D:/" + fileName+ ".txt");
            Console.WriteLine("File Created Successfully!!");
            Console.WriteLine("Enter the Text that you want to write on File");
            Console.ReadLine();
            sw.Flush();
            sw.Close();
        }

        public void OpenFile()
        {
            Console.Clear();
            Console.WriteLine("Enter File Name you want to open");
            string fileName = Console.ReadLine();
            StreamReader sr = new StreamReader("D:/" + fileName + ".txt");
            Console.WriteLine("Content of the File");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            Console.ReadLine();
            sr.Close();
        }

        public void Concate()
        {
            Console.Clear();
            string target = "";
            Console.WriteLine("Enter first File Name");
            string first = Console.ReadLine();
            StreamReader sr = new StreamReader("D:/" + first + ".txt");
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            string str = sr.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = sr.ReadLine();
            }
            target = target + str;
            sr.Close();

            Console.WriteLine("Enter second File Name");
            string second = Console.ReadLine();
            StreamReader sr1 = new StreamReader("D:/" + second + ".txt");
            sr1.BaseStream.Seek(0, SeekOrigin.Begin);
            string str1 = sr1.ReadLine();
            while (str1 != null)
            {
                Console.WriteLine(str1);
                str1 = sr1.ReadLine();
            }
            target = target + str1;
            sr1.Close();

            Console.WriteLine("Enter new File name in which you want to append");
            string third = Console.ReadLine();
            StreamWriter sw = new StreamWriter("D:/" + third + ".txt");
            Console.WriteLine(target);
            System.IO.File.AppendText("D:/" + third + ".txt");
            sw.Flush();
            sw.Close();
        }

        public void copy()
        {
            Console.Clear();
            Console.WriteLine("Enter the file name from which you want to copy");
            string sourceFile = Console.ReadLine();
            Console.WriteLine("Enter the filename to which you want to copy ");
            string destFile = Console.ReadLine();
            File.Delete("D://" + destFile + ".txt");
            File.Copy("D://" + sourceFile + ".txt", "D://" + destFile + ".txt");
            Console.WriteLine("Files copied successfully..");
        }

        public void Rename()
        {
            Console.Clear();
            Console.WriteLine("Enter the file to rename");
            string fileName = Console.ReadLine();
            Console.WriteLine("Enter new file name");
            string newFileName = Console.ReadLine();
            FileInfo fi = new FileInfo("D://" + fileName + ".txt");
            if (fi.Exists)
            {
                fi.MoveTo("D://" + newFileName + ".txt");
                Console.WriteLine("File Renamed successfully!!");
            }
        }
    }
}


