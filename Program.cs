using System;
using System.IO;
using System.Text;

namespace EncodingUTF7
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream theFile = File.Create("C:/Users/antoaneta/Downloads/CodeCool/advancedCSharp/2nd_TW/EncodingUTF7/gitignore_utf7.txt");
            StreamWriter writer = new StreamWriter(theFile, Encoding.UTF7, 512);

            writer.Write("Aut viam inveniam aut faciam: 24*05*1982!");

            writer.Close();
            theFile.Close();
            Console.WriteLine("Hello World!");
        }
    }
}
