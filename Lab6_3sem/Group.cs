using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_3sem
{
    public class Group
    {
        private string Name = "";
        private Student[] student = new Student[30];
        private int Quantity;

        public Group()
        {
            Name = "";
            for (int i = 0; i < 30; i++)
            {
                student[i] = new Student();
                student[i].SetStudent("", "", "");
            }
        }

        public Group(string name)
        {
            Name = name;
            for (int i = 0; i < 30; i++)
            {
                student[i] = new Student();
                student[i].SetStudent("", "", "");
            }
        }
        public Group(string name, Student[] s, int q)
        {
            Name = name;
            Quantity = 0;
            for (int i = 0; i < 30; i++)
            {
                student[i] = new Student();
                student[i].SetStudent("", "", "");
            }
            for (int i = 0; i < 30 && i < q; i++)
            {
                student[i] = new Student();
                student[i].SetStudent("", "", "");
            }
            for (int i = 0; i < 30 && i < q; i++)
            {
                student[i] = s[i];
                Quantity++;
            }
        }
        public string GetName()
        {
            return Name;
        }
        public Student GetStudent(int Num)
        {
            Student s = new Student();
            if (Num >= 0 && Num < 10)
                s = student[Num];

            return s;
        }
        public int GetQuantity()
        {
            return Quantity;
        }
        public void Set(string name, Student[] s, int q)
        {
            Name = name;
            for (int i = 0; i < 30 && i < q; i++)
            {
                student[i] = s[i];
                Quantity++;
            }
        }
        public void SetGroup(string name)
        {
            Name = name;
        }
        public void SetStudent(Student[] s)
        {
            for (int i = 0; i < 30; i++)
            {
                student[i] = s[i];
                Quantity++;
            }
        }
        public void InputGroup()
        {
            this.SetGroup("");
            Console.Write("Введите название группы: ");
            Name = Console.ReadLine();
        }
        public bool AddStudentToGroup(Student Student)
        {
            bool flag = false;

            for (int i = 0; i < 30 && flag == false; i++)
            {
                if (student[i].GetSurname() == "")
                {
                    if (student[i].GetName() == "")
                    {
                        if (student[i].GetPatronymic() == "")
                        {
                            student[i] = Student;
                            flag = true;
                            Quantity++;
                        }
                    }
                }
            }

            return flag;
        }
        public void OutputGroup()
        {
            Console.Write("Название группы: " + Name + "\n");
            Console.WriteLine("Студенты группы: ");
            int i = 0;
            while (student[i].GetSurname() != "" && student[i].GetSurname() != "" && student[i].GetPatronymic() != "")
            {
                Console.Write(i + 1 + ". " + student[i].GetSurname() + " " + student[i].GetSurname() + " " + student[i].GetPatronymic() + "\n");
                i++;
            }
        }
        public int AverageMarkStudent()
        {
            OutputGroup();
            int Nomer,
                QuantityMark = 0,
                QuantitySum = 0,
                AverageMark = 0;
            Console.Write("Выберите студента для подсчёта среднего балла (введите его номер): ");
            Nomer = Convert.ToInt32(Console.ReadLine());
            if (Nomer > 0 && Nomer <= Quantity)
            {
                for (int i = 0; i < 10 && student[Nomer - 1].GetMark(i).Get() != 0; i++)
                {
                    QuantitySum = QuantitySum + student[Nomer - 1].GetMark(i).Get();
                    QuantityMark++;
                }
                AverageMark = QuantitySum / QuantityMark;
                Console.Write("Средний балл студента: " + AverageMark + "\n");
            }
            else
                Console.WriteLine("Неправильно введён номер!");

            return AverageMark;
        }
    }
}
