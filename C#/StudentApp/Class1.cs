using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites
{
    public class Mathematics
    { 
        public double FirstExam{get;set; }

        public double SecondExam { get;set; }

        public double Midterm { get;set; }

        public double Final { get;set; }

        public double Average { get;set; }

        private const double PassGrade = 50;
        public Mathematics() //constructer
        {
            FirstExam = 0;
            SecondExam = 0;
            Final = 0;
            Midterm = 0;
            GetAverage();
        }

        public double GetAverage()
        {
            double sum = FirstExam * 15 + SecondExam * 15 + Midterm * 30 + Final * 40;
            Average = sum / 100; // assign to class-level property
            return Average;
        }


        public void SetGrades()
        {
            double grade;

            Console.WriteLine("matematik first exam: ");
            string input = Console.ReadLine();
            bool result=double.TryParse(input, out grade);
            double FirstExam = grade;
            //double.TryParse(Console.ReadLine(),out grade);

            Console.WriteLine("matematik second exam: ");
            string input2 = Console.ReadLine();
            bool result2 = double.TryParse(input, out grade);
            double SecondExam = grade;

            Console.WriteLine("matematik midterm exam: ");
            string input3 = Console.ReadLine();
            bool result3 = double.TryParse(input, out grade);
            double Midterm = grade;

            Console.WriteLine("matematik final exam: ");
            string input4 = Console.ReadLine();
            bool result4 = double.TryParse(input, out grade);
            double Final = grade;
        }

        public string IsPass()
        {
            if(Average <= PassGrade)
            {
                return "failed";
            }
            else
            {
                return "passed";
            }
        }
    }
}
