using static DelegateLamdaExpression.Exam;

namespace DelegateLamdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //    List<Person> person = new List<Person>

            //{
            //    new Person { Name = "Taceddin", Surname = "Esedzade", Age = 20 },
            //    new Person { Name = "Raheddin", Surname = "Esedzade", Age = 26 },
            //    new Person { Name = "Shaheddin", Surname = "Esedzade", Age = 26 },
            //    new Person { Name = "Maheddin", Surname = "Esedzade", Age = 26 },
            //    new Person { Name = "Samuray", Surname = "Samiyev", Age = 19 },
            //    new Person { Name = "Allahverdi", Surname = "Sultanov", Age = 19 },
            //};
            //    List<Person> sorched = person.FindAll(x => x.Name == "Raheddin");
            //    sorched.ForEach(x => Console.WriteLine(x.Name + " " + x.Surname + " " + x.Age + "\n\n\n"));

            //    List<Person> surnamesorched = person.FindAll(x => x.Surname.Substring(x.Surname.Length - 2) == "ov" || x.Surname.Substring(x.Surname.Length - 3) == "ova");

            //    surnamesorched.ForEach(x => Console.WriteLine(x.Name + " " + x.Surname + " " + x.Age + "\n\n\n"));

            //    List<Person> agesorched = person.FindAll(x => x.Age >= 20);
            //    agesorched.ForEach(x => Console.WriteLine(x.Name + " " + x.Surname + " " + x.Age));

            #endregion



            pExam exam1 = new("Fizika", new DateTime(2024, 10, 24, 15, 30, 00), 3);
            pExam exam2 = new("Kimya", DateTime.Now, 3);
            pExam exam3 = new("c#", new DateTime(2024, 10, 23, 12, 55, 00), 1.5);
            pExam exam4 = new("java", new DateTime(2024, 11, 10, 11, 40, 00), 2);
            pExam exam5 = new("Match", new DateTime(2024, 10, 29, 12, 30, 00), 1.2);

            List<pExam> exams = new List<pExam>();
            exams.Add(exam1);
            exams.Add(exam2);
            exams.Add(exam3);
            exams.Add(exam4);
            exams.Add(exam5);


            Console.WriteLine("Son 1 heftede bash tutan imtahanlar");
            exams.FindAll(x => x.StartTime.AddDays(7) >= DateTime.Now && x.StartTime < DateTime.Now).ForEach(x => Console.WriteLine($"{x.Subject}   {x.ExamDuration}"));
            Console.WriteLine("Hazirda davam eden imtahanlar");
            exams.FindAll(x => x.StartTime < DateTime.Now && x.EndTime > DateTime.Now).ForEach(x => Console.WriteLine($"{x.Subject}   {x.ExamDuration}"));
            Console.WriteLine("2 saatdan artiq davam eden imtahanlar");
            exams.FindAll(x => x.ExamDuration > 2).ForEach(x => Console.WriteLine($"{x.Subject}    {x.ExamDuration}"));














        }
    }
}
