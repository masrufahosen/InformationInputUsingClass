using System;
using System.IO;

namespace InformationInputUsingClass
{
    class Program
    {
        static void Main(string[] args)
        {
            string fn, ln, dob;
            using (StreamReader sr = new StreamReader(@"C:\Users\Public\data.txt"))
            {
                fn=sr.ReadLine();
                ln = sr.ReadLine();
                dob = sr.ReadLine();
                sr.Close();
            }

            Student s1;
            s1 = new Student(fn, ln, DateTime.Parse(dob));
            Console.WriteLine(s1.GetInfo());

            using(StreamWriter sw = new StreamWriter(@"C:\Users\Public\data.txt", true))
            {
                sw.WriteLine("Sorif");
                sw.WriteLine("Talukdar");
                sw.WriteLine(DateTime.Now.ToString());
                sw.Close();
            }
            
        }
    }

}
