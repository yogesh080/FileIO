using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIO
{
    public class StreamReaderWriterOops
    {
        public void WriteUsingStreamWriter()
        {
            string path = @"/Users/yogesh/Desktop/bridgelab/bridgelab/FileIO/FileIO/Example.txt";
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("heLLO World");
                sr.Close();
                Console.WriteLine(File.ReadAllText(path));
            }
            Console.ReadKey();

        }

        public void ReadFrromReader()
        {
            string path = @"/Users/yogesh/Desktop/bridgelab/bridgelab/FileIO/FileIO/Example.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                String s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.ReadLine();
            }

        }
    }
    
}
