using System;
using System.IO;

namespace labba2sem3._3
{
    class Program
    {
        static void Main(string[] args)
        {



            string s = File.ReadAllText(@"C:\Users\Laptop\Desktop\input.txt");
            
            string[] parts = s.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int kil = 0;
            
                kil += parts.Length;
            
            StreamWriter stream2 = new StreamWriter(@"C:\Users\Laptop\Desktop\output.txt");
            stream2.Write(kil);
           
            stream2.Close();

        }
       
    }
}
