using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarksEntry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter Student Name");
            //string studentName = Console.ReadLine();

            //Console.WriteLine("Enter Student ID");
            //int studentId = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Total Marks Here");
            //double totalMark = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter Obtain Marks Marks Here");
            //double obtainMark = double.Parse(Console.ReadLine());
            Marks mark = new Marks("md.Mehedi Hasan",1280692,10,9);
            mark.displayMark();
            Console.ReadKey();

        }
        public class Marks
        {
            string studentName;
            int studentId;
            double totalMark;
            double obtainMark;
            
            public Marks(string name, int id, double tMark, double oMark)
            {
                studentName = name;
                studentId = id;
                totalMark = tMark;
                obtainMark = oMark;
            }
            public void displayMark()
            {
                Console.WriteLine($"Student Name: {studentName}, ID = {studentId}, Total Marks: {totalMark}, Obtain Marks: {obtainMark}");
            }
        }
    }
}
