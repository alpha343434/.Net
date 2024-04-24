namespace Entites
{
    public class Student
    {
        public string Name { get; set; }

        public int StudentNumber { get; set; }

        public string Username { get; set;}

        public const string EMail = "itu.edu.tr";

        public Mathematics Mathematics { get; set; }

        public Student(string name)
        {
            Name = name;
            Mathematics math = new Mathematics();
            Mathematics = math;
        }
    }
}
