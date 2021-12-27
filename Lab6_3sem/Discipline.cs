using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_3sem
{
    public class Discipline
    {
        private string Name = "";
        private Teacher teacher = new Teacher();

        public Discipline()
        {
            Name = "";
            teacher.Set("", "", "");
        }
        public string GetDiscipline()
        {
            return Name;
        }
        public Teacher GetTeacher()
        {
            return teacher;
        }
        public void Set(string name)
        {
            Name = name;
            teacher.Set("", "", "");
        }
        public void InputDiscipline(Teacher Teacher)
        {
            this.Set("");
            Console.Write("Введите название дисциплины: ");
            Name = Console.ReadLine();
            teacher = Teacher;
        }
        public bool AddTeacherToDiscipline(Teacher Teacher)
        {
            bool flag = false;

            if (teacher.GetSurname() == "")
            {
                teacher = Teacher;
                flag = true;
            }

            return flag;
        }
        public void OutputDiscipline()
        {
            Console.Write("Название дисциплины: " + Name + "\n");
            teacher.OutputTeacher();
        }
    }
}
