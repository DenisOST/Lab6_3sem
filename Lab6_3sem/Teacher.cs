using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_3sem
{
    public class Teacher
    {
        private string Surname = "";
        private string Name = "";
        private string Patronymic = "";
        public string name
        {
            get => Name;
            set => Name = value;
        }
        public string surname
        {
            get => Surname;
            set => Surname = value;
        }
        public string patronymic
        {
            get => Patronymic;
            set => Patronymic = value;
        }
        public Teacher()
        {
            Surname = "";
            Name = "";
            Patronymic = "";
        }
        public string GetSurname()
        {
            return Surname;
        }
        public string GetName()
        {
            return Name;
        }
        public string GetPatronymic()
        {
            return Patronymic;
        }
        public void Set(string surname, string name, string patronymic)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
        }
        public void InputTeacher()
        {
            this.Set("", "", "");
            Console.Write("Введите фамилию преподавателя: ");
            Surname = Console.ReadLine();
            Console.Write("Введите имя преподавателя: ");
            Name = Console.ReadLine();
            Console.Write("Введите отчество преподавателя: ");
            Patronymic = Console.ReadLine();
        }
        public void OutputTeacher()
        {
            Console.Write("ФИО преподавателя: " + Surname + " " + Name + " " + Patronymic + "\n");
        }
    }
}
