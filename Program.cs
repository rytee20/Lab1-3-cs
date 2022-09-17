using System;

namespace lab1
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создаем студента и выводим через ToShortString");
            Student student1 = new Student();
            Console.WriteLine(student1.ToShortString());

            Console.WriteLine("\nЗначение индексатора для Education.Specialist");
            Console.WriteLine(student1[Education.Specialist]);

            Console.WriteLine("\nЗначение индексатора для Education.Bachelor");
            Console.WriteLine(student1[Education.Bachelor]);

            Console.WriteLine("\nЗначение индексатора для Education.SecondEducation");
            Console.WriteLine(student1[Education.SecondEducation]);

            Console.WriteLine("\nПрисвоить значения всем свойствам студента и вывести через ToString");
            student1.SD.FN = "Екатерина";
            student1.SD.LN = "Афонина";
            student1.SD.DoB = new DateTime(2003,12,13);
            student1.DoE = Education.Bachelor;
            student1.GN = 21;
            Exam exam = new Exam("Математика", 4, new DateTime(2022, 6, 18));
            student1.AddExams(exam);
            Console.WriteLine(student1.ToString());

            Console.WriteLine("\nДобавить экзаамены и вывести средний балл");
            exam = new Exam("Физика", 5, new DateTime(2022, 6, 12));
            student1.AddExams(exam);
            exam = new Exam("ПрЧМИ", 5, new DateTime(2022, 6, 24));
            student1.AddExams(exam);
            Console.WriteLine(student1.ToString());
            Console.WriteLine(student1.ToShortString());

            Console.WriteLine("\nСравнить время выполнения операций");
            Console.WriteLine("Введите число строк и столбцов для двумернго массива, в качестве разделителя вы можете использовать ' ' (пробел), ',' (запятая), '.' (точка), '/' (косая черта)");
            student1 = new Student();
            string input;
            input=Console.ReadLine();
            string[] s = input.Split(' ', ',','/','.');
            int nrow = Convert.ToInt32(s[0]),
                ncolumn = Convert.ToInt32(s[1]);
            Console.WriteLine("Вы ввели: ", nrow.ToString()+' '+ncolumn.ToString());

            Student[] students = new Student[nrow * ncolumn];
            for (int i = 0; i < nrow * ncolumn; i++)
            {
                students[i] = new Student();
            }
            int time1 = Environment.TickCount;
            for (int i=0;i< nrow * ncolumn;i++)
            {
                students[i].GN = 5;
                //Console.WriteLine(students[i].ToString());
            }
            int time2 = Environment.TickCount;
            Console.WriteLine("Для одномерного массива: "+(time2-time1));

            Student[,] students2 = new Student[nrow,ncolumn];
            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncolumn; j++)
                {
                    students2[i,j] = new Student();
                }
            }
            time1 = Environment.TickCount;
            for (int i = 0; i < nrow; i++)
            {
                for (int j = 0; j < ncolumn; j++)
                {
                    students2[i, j].GN=4;
                }
            }
            time2 = Environment.TickCount;
            Console.WriteLine("Для двумерного массива: " + (time2 - time1));

            Student[][] students3 = new Student[4][];
            int countofcolumns;
            int countofall = nrow * ncolumn;
            for(int i=0;i<4;i++)
            {
                if (i == 0)
                {
                    countofcolumns = (nrow * ncolumn) * 40 / 100;
                    countofall = countofall - countofcolumns;
                    students3[i] = new Student[countofcolumns];
                }
                if (i == 1)
                {
                    countofcolumns = (nrow * ncolumn) * 30 / 100;
                    countofall = countofall - countofcolumns;
                    students3[i] = new Student[countofcolumns];
                }
                if (i == 2)
                {
                    countofcolumns = (nrow * ncolumn) * 20 / 100;
                    countofall = countofall - countofcolumns;
                    students3[i] = new Student[countofcolumns];
                }
                if (i == 3)
                {
                    students3[i] = new Student[countofall];
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < students3[i].Length; j++)
                {
                    students3[i][j] = new Student();
                }
            }
            time1 = Environment.TickCount;
            for (int i=0;i<4;i++)
            {
                for(int j=0; j<students3[i].Length;j++)
                {
                    students3[i][j].GN = 4;
                }
            }
            time2 = Environment.TickCount;
            Console.WriteLine("Для ступенчатого массива: " + (time2 - time1));
        }
    }
}
