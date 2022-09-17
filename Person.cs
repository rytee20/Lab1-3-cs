using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Person
    {
        private string FirstName;            //имя
        private string LastName;             //фамилия
        private System.DateTime DateOfBirth; //дата рождения

        public Person() //конструктор без параметров
        {
            FirstName = "firstname";
            LastName = "lastname";
            DateOfBirth = new DateTime(2022, 1, 1);
        }

        public Person(string firstname, string lastname, DateTime dateofbirth) //конструктор с параметрами
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.DateOfBirth = dateofbirth;
        }

        public string FN //get set для имени
        {
            get
            {
                return FirstName;
            }

            set
            {
                FirstName = value;
            }
        }

        public string LN //get set для фамилии
        {
            get
            {
                return LastName;
            }

            set
            {
                LastName = value;
            }
        }

        public DateTime DoB //get set для даты рождения
        {
            get
            {
                return DateOfBirth;
            }

            set
            {
                DateOfBirth = value;
            }
        }

        public int intDoB //int get set для даты рождения
        {
            get
            {
                return Convert.ToInt32(DateOfBirth.Year);
            }

            set
            {
                DateOfBirth = new DateTime(DateOfBirth.Day, DateOfBirth.Month, value);
            }
        }

        public override string ToString() //перегруженная версия виртуального метода tostring возвращающий строку со значениями всех полей класса
        {
            return "\nИмя: " + FirstName + ' ' + LastName + "\nДата рождения: " + DateOfBirth;
        }

        public string ToShortString() //виртуальный метод toshortstring возвращающий имя и фамилию
        {
            return "\nИмя: " + FirstName + ' ' + LastName;
        }
    }
}
