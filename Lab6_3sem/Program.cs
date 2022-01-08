﻿using System;

namespace Lab6_3sem
{
    class Program
    {
        static void Main(string[] args)
        {
			int i;

			Teacher[] Teachers = new Teacher[3];

			for (i = 0; i < 3; i++)
            {
				Teachers[i] = new Teacher();
            }

			Teachers[0].Set("Попова", "Ирина", "Андреевна");
			Teachers[1].Set("Иванова", "Елена", "Сергеевна");
			Teachers[2].Set("Буянов", "Виталий", "Юрьевич");

			Discipline[] Disciplines = new Discipline[3];

			for (i = 0; i < 3; i++)
			{
				Disciplines[i] = new Discipline();
			}

			Disciplines[0].Set("Программирование");
			Disciplines[1].Set("Математика");
			Disciplines[2].Set("Экономика");

			for (i = 0; i < 3; i++)
			{
				Disciplines[i].AddTeacherToDiscipline(Teachers[i]);
			}

			Mark[] Marks1 = new Mark[3]; 
			Mark[] Marks2 = new Mark[3]; 
			Mark[] Marks3 = new Mark[3];

			for (i = 0; i < 3; i++)
			{
				Marks1[i] = new Mark();
			}
			for (i = 0; i < 3; i++)
			{
				Marks2[i] = new Mark();
			}
			for (i = 0; i < 3; i++)
			{
				Marks3[i] = new Mark();
			}

			Marks1[0].Set(60);
			Marks1[1].Set(80);
			Marks1[2].Set(75);
			Marks2[0].Set(50);
			Marks2[1].Set(40);
			Marks2[2].Set(80);
			Marks3[0].Set(100);
			Marks3[1].Set(30);
			Marks3[2].Set(80);

			Student[] Students = new Student[3];

			for (i = 0; i < 3; i++)
			{
				Students[i] = new Student();
			}

			Students[0].SetStudent("Андреев", "Сергей", "Васильевич");
			Students[1].SetStudent("Авдеев", "Антон", "Александрович");
			Students[2].SetStudent("Сергеев", "Юрий", "Владимирович");

			for (i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					Students[i].AddDisciplineToStudent(Disciplines[j]);
				}
			}

			for (int j = 0; j < 3; j++)
			{
				Students[0].AddMarkToStudent(Disciplines[j], Marks1[j]);
			}

			for (int j = 0; j < 3; j++)
			{
				Students[1].AddMarkToStudent(Disciplines[j], Marks2[j]);
			}

			for (int j = 0; j < 3; j++)
			{
				Students[2].AddMarkToStudent(Disciplines[j], Marks3[j]);
			}

			Group Groups = new Group();
			Groups.SetGroup("ПИ-01");

			for (i = 0; i < 3; i++)
			{
				Groups.AddStudentToGroup(Students[i]);
			}

			for (i = 0; i < 3; i++)
			{
				Teachers[i].OutputTeacher();
				Console.WriteLine();
			}

			for (i = 0; i < 3; i++)
			{
				Disciplines[i].OutputDiscipline();
				Console.WriteLine();
			}

			for (i = 0; i < 3; i++)
			{
				Students[i].OutputStudent();
				Console.WriteLine();
			}

			Groups.OutputGroup();
			Console.WriteLine();

			Groups.AverageMarkStudent();
			Console.WriteLine();

			Console.WriteLine("10) Для полей добавить свойства и продемонстрировать работу с ними");
			Teacher TeacherForTest = new Teacher();
			TeacherForTest.surname = "Хомяков";
			TeacherForTest.name = "Никита";
			TeacherForTest.patronymic = "Иванович";
			TeacherForTest.OutputTeacher();
			Console.WriteLine();

			Console.WriteLine("11) Cоздать массив объектов и продемонстрировать работу с ним");
			Teachers[0].Set("Попова", "Ирина", "Андреевна");
			Teachers[1].Set("Иванова", "Елена", "Сергеевна");
			Teachers[2].Set("Буянов", "Виталий", "Юрьевич");
			for (i = 0; i < 3; i++)
			{
				Teachers[i].OutputTeacher();
				Console.WriteLine();
			}
			Console.WriteLine();

			Console.WriteLine("12) В отдельной ветке проекта заменить класс (class) на структуру (struct). Продемонстрировать различие между присваиванием объектов класса и структуры;");
			Mark MarkFor12 = new Mark();
			Teacher TeacherFor12 = new Teacher();
			MarkFor12.Set(90);
			TeacherFor12.Set("Мукин", "Василий", "Витальевич");
			Console.WriteLine("Элемент структуры до копирования:");
			MarkFor12.OutputMark();
			Console.WriteLine("Элемент класса до копирования:");
			TeacherFor12.OutputTeacher();
			Console.WriteLine("Элемент структуры копируется на:");
			Marks1[0].OutputMark();
			Console.WriteLine("Элемент класса копируется на:");
			Teachers[0].OutputTeacher();
			Console.Write("\n");
			MarkFor12 = Marks1[0];
			TeacherFor12 = Teachers[0];
			Console.WriteLine("Элемент структуры после копирования:");
			MarkFor12.OutputMark();
			Console.WriteLine("Элемент класса после копирования:");
			TeacherFor12.OutputTeacher();
			Console.Write("\n");
			Console.WriteLine("Если изменить те объекты, на которые менялись объект класса и структуры:");
			Marks1[0].Set(75);
			Teachers[0].Set("Краснов", "Николай", "Михайлович");
			Marks1[0].OutputMark();
			Teachers[0].OutputTeacher();
			Console.Write("\n");
			Console.WriteLine("То новые объекты будут таковыми:");
			MarkFor12.OutputMark();
			TeacherFor12.OutputTeacher();
			Console.WriteLine("Объект класса изменился, потому что копируется ссылка на объект, а объект структуры не изменился, т.к. копируются значения полей.");
		}
    }
}