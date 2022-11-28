namespace homework_class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Asiman", "Qasimzada", "P327", 95, false);
            Student student2 = new Student("Ziya", "Asgerov", "P327", 65, false);


            student1.studentInfo();
            student1.secondExam();
            
            student1.fullName();
            

        }
    }
}