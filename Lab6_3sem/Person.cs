using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_3sem
{
    interface Human
    {
        void InputFIO();

        void OutputInformation();

        string WhoIs();

        public Person ShallowCopy();

        public Person DeepCopy();
    }
    public class Person : Human
    {
        protected string Surname;
        protected string Name;
        protected string Patronymic;

        public string surname
        {
            get => Surname;
            set => Surname = value;
        }

        public string name
        {
            set => Name = value;
        }

        public string patronymic
        {
            get => Patronymic;
            set => Patronymic = value;
        }

        public Person()
        {
            Surname = "";
            Name = "";
            Patronymic = "";
        }

        public Person(string surname)
        {
            Surname = surname;
            Name = "";
            Patronymic = "";
        }

        public Person(string surname, string name, string patronymic)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
        }

        public string GetSurname()
        {
            return this.Surname;
        }

        public string GetName()
        {
            return this.Name;
        }

        public string GetPatronymic()
        {
            return this.Patronymic;
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

        public void Set(string surname, string name, string patronymic)

        {
            this.Surname = surname;
            this.Name = name;
            this.Patronymic = patronymic;
        }

        public virtual void InputFIO()
        {
            Console.Write("Введите Фамилию: ");
            Surname = Console.ReadLine();
            Console.Write("Введите имя: ");
            Name = Console.ReadLine();
            Console.Write("Введите отчество: ");
            Patronymic = Console.ReadLine();
        }

        public virtual void OutputInformation()
        {
            Console.Write("ФИО: " + Surname + " " + Name + " " + Patronymic + "\n");
        }

        public void AdditionSapces()
        {
            Surname = Surname + " ";
            Name = Name + " ";
            Patronymic = Patronymic + " ";
        }

        public virtual string WhoIs()
        {
            return "Кто-то";
        }

        public void SayHello()
        {
            Console.WriteLine(WhoIs() + " говорит привет!");
        }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person other = (Person)this.MemberwiseClone();
            other.Surname = String.Copy(Surname);
            other.Name = String.Copy(Name);
            other.Patronymic = String.Copy(Patronymic);
            return other;
        }
    }
}
