using System;
using System.IO;
namespace FileIO
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Program.ReadFile();

            Program.Deletefile();


            //StreamReaderWriterOops readThoughStreamReader = new StreamReaderWriterOops();
            //readThoughStreamReader.ReadFrromReader();
            //readThoughStreamReader.WriteUsingStreamWriter();

        }
        public static void FileExists()
        {
            string path = @"/Users/yogesh/Desktop/bridgelab/bridgelab/FileIO/FileIO/Example.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("file exist");
            }
            
            Console.ReadKey();
        }
        public static void ReadFile()
        {
            string path = @"/Users/yogesh/Desktop/bridgelab/bridgelab/FileIO/FileIO/Example.txt";
            string[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);

            Console.ReadKey();

        }

        public static void Filecopy()
        {
            string path = @"/Users/yogesh/Desktop/bridgelab/bridgelab/FileIO/FileIO/Example.txt";
            string copypath = @"/Users/yogesh/Desktop/bridgelab/bridgelab/FileIO/FileIO/copyExample.txt";
            File.Copy(path, copypath, true);
            Console.ReadKey();

        }
        public static void Deletefile()
        {
            string copypath = @"/Users/yogesh/Desktop/bridgelab/bridgelab/FileIO/FileIO/TextFile1.txt";

            File.Delete(copypath);
            Console.ReadKey();



        }
    }
    
}