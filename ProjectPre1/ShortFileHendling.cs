using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProjectPre1
{
    internal class ShortFileHendling
    {
        internal String path = "d://chhatrola_yash.txt";
        internal String data;
        internal void createFile()
        {
            try
            {
                if (File.Exists(path))
                {
                    Console.WriteLine("File Already Exist");
                }
                else
                {
                    FileStream fs = File.Create(path);
                    fs.Close();
                    Console.WriteLine("File Created Successfuly");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        internal void addContentOnFile()
        {
            try
            {
                //StreamWriter fw = new StreamWriter(path);
                //fw.WriteLine("my Name is Chhatrola Yash Kishorbhai");
                //fw.Close();
                //Console.WriteLine("Data Save Successfuly");
                Console.WriteLine("Enter Data");
                data = Console.ReadLine();
                File.WriteAllText(path, data);
                Console.WriteLine("Data Save Successfuly");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        internal void appendContentOnFile()
        {
            try
            {
                StreamWriter fw = new StreamWriter(path, true);
                fw.WriteLine("I am working on C# in .net");
                fw.Close();
                Console.WriteLine("Data Save Successfuly");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        internal void readDataOnFile()
        {
            try
            {
                //StreamReader sr = new StreamReader(path);
                //String data = sr.ReadToEnd();
                //Console.WriteLine(data);
                //sr.Close();
                data=File.ReadAllText(path);
                Console.WriteLine(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        internal void deleteFileOperation()
        {
            try
            {
                File.Delete(path);
                Console.WriteLine("detlete file successfuly");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
    }
}
