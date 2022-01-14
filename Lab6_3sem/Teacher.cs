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
        public Teacher(string surname)
        {
            Surname = surname;
            Name = "";
            Patronymic = "";
        }
        public Teacher(string surname, string name, string patronymic)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
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
        public void SetSurname(string surname)
        {
            Surname = surname;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetPatronymic(string patronymic)
        {
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
        public void ShowingWorkingWithString()
        {
            Surname = Surname + "Демонстрация";
            Name = Name + "работы со";
            Patronymic = Patronymic + "строками :)";
        }
    }
}
