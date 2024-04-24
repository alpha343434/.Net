using Entites;
using System;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

List<Student> students = new List<Student>();

//string name = "";
//Student student = new Student("zehra");



while (true)
{
    Console.WriteLine("--- Yönetim Paneli ---\n");
    Console.WriteLine("1- öğrencileri listele");
    Console.WriteLine("2- öğrenci ekle");
    Console.WriteLine("3- çıkış");

    string choise = Console.ReadLine();

    switch(choise){
        case "1":
            Console.WriteLine("öğrenciler listeleniyor...");
            GetStudent(students);
            break;
        case "2":
            AddStudent(students);
            break;
        case "3":
            Console.WriteLine("çıkış yapıldı");
            Environment.Exit(0);
            break;
        default:
            Console.WriteLine("geçersiz");
            break;
    }
}

bool AddStudent(List<Student> students)
{
    try
    {
        Console.WriteLine("öğrenci ekleniyor...");
        Thread.Sleep(1000);

        Console.Write("öğrenci ismi: ");
        string name = Console.ReadLine();

        Student student = new Student(name);

        students.Add(student);
        Console.WriteLine("matematik notları: ");
        student.Mathematics.SetGrades();

        Console.WriteLine("öğrenci eklendi\n");
        return true;
    }
    catch(Exception)
    {
        Console.WriteLine("öğrenci eklenemedi.");
        return false;

    }

}

void GetStudent(List<Student> students)
{
    Console.WriteLine("öğrenci listesi: \n");
    foreach (var student in students)
    {
        Console.WriteLine($"{student.Name} -- {student.Mathematics.IsPass()}");
    }
    Console.WriteLine($"{students.Count} öğrenci listelendi.\n");
}