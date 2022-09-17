using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    enum Education //класс для перечесления возможных форм обучения, лучше сделать для него отдельный файл, но я не сделала
    {
        Specialist,
        Bachelor,
        SecondEducation
    }

    class Student
    {
        private Person StudentData;          //данные о студенте
        private Education DegreeOfEducation; //форма обучения
        private int GroupNumber;             //номер группы
        private Exam[] ListOfExams;          //сданые экзамены


        public Student() //конструктор без параметров
        {
            StudentData = new Person();
            DegreeOfEducation = Education.Specialist;
            GroupNumber = 1;
        }

        public Student(Person studentdata, int groupnumber, Education degreeofeducation) //конструктор с параметрами
        {
            this.StudentData = studentdata;
            this.GroupNumber = groupnumber;
            this.DegreeOfEducation = degreeofeducation;
        }

        public Person SD //get set для данных о студенте
        {
            get
            {
                return StudentData;
            }

            set
            {
                StudentData = value;
            }
        }

        public Education DoE //get set для формы обучения
        {
            get
            {
                return DegreeOfEducation;
            }

            set
            {
                DegreeOfEducation = value;
            }
        }

        public int GN //get set для номера группы
        {
            get
            {
                return GroupNumber;
            }

            set
            {
                GroupNumber = value;
            }
        }

        public Exam[] Es //get set для экзаменов
        {
            get
            {
                return ListOfExams;
            }

            set
            {
                ListOfExams = value;
            }
        }

        public double GPA //подсчет среднего балла
        {
            get
            {
                if (ListOfExams == null)
                    return 0;
                int sum = 0;
                int count = 0;
                foreach (Exam exam in ListOfExams)
                {
                    sum = sum + exam.Mark;
                    count = count + 1;
                }
                return (double)sum / count;
            }
        }

        public bool this [Education index] //индексатор
        {
            get
            {
                if (DegreeOfEducation == index)
                    return true;
                else return false;
            }
        }

        public void AddExams (params Exam[] exams) //добавление экзаменов
        {
            if(ListOfExams == null)
            {
                ListOfExams = new Exam[exams.Length];
                exams.CopyTo(ListOfExams, 0);
            }
            else
            {
                Exam[] old_exams= new Exam[ListOfExams.Length];
                ListOfExams.CopyTo(old_exams,0);

                ListOfExams = new Exam[old_exams.Length + exams.Length];
                old_exams.CopyTo(ListOfExams, 0);
                exams.CopyTo(ListOfExams, old_exams.Length);
            }
        }

        public override string ToString()
        {
            string exams="";
            if (ListOfExams == null)
                exams = "Нет сданных экзаменов";
            else
            {
                foreach (Exam exam in ListOfExams)
                {
                    exams += exam.ToString();
                }
            }

            return "\nДанные студента: " + StudentData + "\nФорма обучения: " + DegreeOfEducation + "\nНомер группы: " + GroupNumber + "\nСданные экзамены: " + exams;
        }

        public string ToShortString()
        {
            return "\nДанные студента: " + StudentData + "\nФорма обучения: " + DegreeOfEducation + "\nНомер группы: " + GroupNumber + "\nСредний балл: " + GPA;
        }
    }
}
