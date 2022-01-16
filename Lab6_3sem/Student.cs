using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_3sem
{
    public class Student
    {
        private string Surname = "";
        private string Name = "";
        private string Patronymic = "";
        private Mark[] mark = new Mark[10];
        private Discipline[] discipline = new Discipline[10];

        public Student()
        {
            Surname = "";
            Name = "";
            Patronymic = "";
            for (int i = 0; i < 10; i++)
            {
                mark[i] = new Mark();
                mark[i].Set(0);
            }
            for (int i = 0; i < 10; i++)
            {
                discipline[i] = new Discipline();
                discipline[i].SetName("");
            }
        }
        public Student(string surname)
        {
            Surname = surname;
            Name = "";
            Patronymic = "";
            for (int i = 0; i < 10; i++)
            {
                mark[i] = new Mark();
                mark[i].Set(0);
            }
            for (int i = 0; i < 10; i++)
            {
                discipline[i] = new Discipline();
                discipline[i].SetName("");
            }
        }
        public Student(string surname, string name, string patronymic, Mark[] m, int M, Discipline[] d, int D)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            for (int i = 0; i < 10; i++)
            {
                mark[i] = new Mark();
                mark[i].Set(0);
            }
            for (int i = 0; i < 10; i++)
            {
                discipline[i] = new Discipline();
                discipline[i].SetName("");
            }
            for (int i = 0; i < 10 && i < M; i++)
            {
                mark[i] = m[i];
            }
            for (int i = 0; i < 10 && i < D; i++)
            {
                discipline[i] = d[i];
            }
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
        public Mark GetMark(int Num)
        {
            Mark m = new Mark();
            if (Num >= 0 && Num < 10)
                m = mark[Num];

            return m;
        }
        public Discipline GetDiscipline(int Num)
        {
            Discipline d = new Discipline();
            if (Num >= 0 && Num < 10)
                d = discipline[Num];

            return d;
        }
        public void SetStudent(string surname, string name, string patronymic)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;

            for (int i = 0; i < 10; i++)
            {
                mark[i].Set(0);
            }

            for (int i = 0; i < 10; i++)
            {
                discipline[i].SetName("");
            }
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

        public void SetMark(Mark[] m)
        {
            for (int i = 0; i < 10; i++)
            {
                mark[i] = m[i];
            }
        }

        public void SetDiscipline(Discipline[] d)
        {
            for (int i = 0; i < 10; i++)
            {
                discipline[i] = d[i];
            }
        }
        public void InputStudent()
        {
            this.SetStudent("", "", "");
            Console.Write("Введите фамилию студента: ");
            Surname = Console.ReadLine();
            Console.Write("Введите имя студента: ");
            Name = Console.ReadLine();
            Console.Write("Введите отчество студента: ");
            Patronymic = Console.ReadLine();
        }
        public bool AddDisciplineToStudent(Discipline Discipline)
        {
            bool flag = false;

            for (int i = 0; i < 10 && flag == false; i++)
            {
                if (discipline[i].GetDiscipline() == "")
                {
                    discipline[i] = Discipline;
                    flag = true;
                }
            }

            return flag;
        }
        public bool AddMarkToStudent(Discipline Discipline, Mark Mark)
        {
            bool flag = false;

            for (int i = 0; i < 10 && flag == false; i++)
            {
                if (discipline[i].GetDiscipline() == Discipline.GetDiscipline())
                {
                    if (discipline[i].GetTeacher().GetSurname() == Discipline.GetTeacher().GetSurname())
                    {
                        if (discipline[i].GetTeacher().GetName() == Discipline.GetTeacher().GetName())
                        {
                            if (discipline[i].GetTeacher().GetPatronymic() == Discipline.GetTeacher().GetPatronymic())
                            {
                                mark[i] = Mark;
                                flag = true;
                            }
                        }
                    }
                }
            }

            return flag;
        }
        public void OutputStudent()
        {
            Console.Write("ФИО студента: " + Surname + " " + Name + " " + Patronymic + "\n");
            Console.Write("Дисциплины: ");
            int i = 0;
            while (discipline[i].GetDiscipline() != "")
            {
                Console.Write("|" + discipline[i].GetDiscipline() + "| ");
                i++;
            }
            Console.Write("\n");
            Console.Write("Баллы: ");
            i = 0;
            while (mark[i].Get() != 0)
            {
                Console.Write("|" + mark[i].Get() + "| ");
                i++;
            }
            Console.Write("\n");
        }
    }
}
