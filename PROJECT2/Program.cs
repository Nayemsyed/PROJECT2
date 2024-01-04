using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECT2
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StreamReader studentdetails = new StreamReader("D:\\Mphasis\\Project2\\Studentdetails.txt");
                string str = studentdetails.ReadToEnd();
                Console.WriteLine();
                Console.WriteLine(str);
                studentdetails.Close();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

