using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace homework_class
{
    public class Student
    { 
        public string Name;
        public string Surname;
        public string Group;
        public byte Point;
        public bool isGraduated;

        public Student(string name,string surname,string group,byte point,bool isgraduated):this(point,isgraduated)
        {
            Name = name;
            Surname = surname;
            Group = group;
        }
        public Student(byte point, bool isgraduated):this(isgraduated)
        {
            Point = point;
        }
        public Student(bool isgraduated)
        {
            isGraduated = isgraduated;
        }
        public void fullName()
        {
            Console.WriteLine("Fullname:"+Name+" "+Surname);
        }
        public void studentInfo()
        {
            Console.WriteLine("Ad Soyad:"+Name+" "+Surname);
            Console.WriteLine("Group:"+Group +"      "+"Point:"+Point );
            if (isGraduated == false)
            {
                Console.WriteLine("Telebe helede tehsil alir");
            }
            else
            {
                Console.WriteLine("Telebe mezun olub");
            }

        }
        public void secondExam()
        {
            if (Point > 80)
            {
                Console.WriteLine("Telebe ikinci imtahana gire biler");
            }
            else
            {
                Console.WriteLine("Teessuf ki,telebenin bali ikinci imtahan ucun yeterli deyil");
            }
        }

    }
}
