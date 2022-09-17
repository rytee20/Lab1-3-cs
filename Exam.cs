using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Exam
    {
        public string SubjectName;         //название предмета
        public int Mark;                   //оценка
        public System.DateTime DateOfExam; //дата экзамена

        public Exam() //конструктор без параметров
        {
            SubjectName = "English";
            Mark = 5;
            DateOfExam = new DateTime(2022, 1, 1);
        }

        public Exam(string subjectname, int mark, DateTime dateofexam) //конструктор с параметрами
        {
            this.SubjectName = subjectname;
            this.Mark = mark;
            this.DateOfExam = dateofexam;
        }

        public override string ToString() //перегруженная версия виртуального метода tostring возвращающий строку со значениями всех полей класса
        {
            return "\nПредмет: " + SubjectName + "\nОценка: " + Mark + "\nДата экзамена: " + DateOfExam;
        }
    }
}
