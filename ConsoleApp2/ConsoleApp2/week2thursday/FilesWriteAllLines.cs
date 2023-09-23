using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.week2thursday
{
    internal class FilesWriteAllLines
    {
        public static void FileWriteAllLines()
        {
            String fname = @"c:\temp\myfileA.txt";
            string[] lines =
            {
            "Chennai is the capital city.",
            "Madurai is the temple City",
            "Salem is the steal city"
            };
            try
            {
                File.WriteAllLines(fname, lines);
                System.Console.WriteLine("File Created");
            }
            catch (Exception err)
            {
                Console.WriteLine($"ERROR!!! {err.Message}");
            }
        }

    }
    public static byte[] Logo 
    {
        get
        {
            byte[] _logoByte = null;
            if(_logoByte == null)
            {
                _logoByte = FilesWriteAllLines.ReadAllLines(@"c:\temp\Html_logo.png");
            }
            return _logoByte;   
        }
    }
}
