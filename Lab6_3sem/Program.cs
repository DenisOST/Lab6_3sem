using System;

namespace Lab6_3sem
{
    class Program
    {
		static void Main(string[] args)
		{
			int i;

			Mark mark1 = new Mark();
			Console.WriteLine("Лабораторная 10\n");
			Console.WriteLine("Придумать разумное использование в ваших проектах защищенных блоков (try-блоки), перехватов исключений (catch-блоки) и инициализации исключений (инструкция throw)\n");
			Console.WriteLine("Введите оценку - число в пределах от 0 до 100!\n");
			while (mark1.Get() == 0)
			{
				mark1.InputMark();
			}
			Console.WriteLine("Введенная оценка: " + mark1.Get());

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

			Disciplines[0].SetName("Программирование");
			Disciplines[1].SetName("Математика");
			Disciplines[2].SetName("Экономика");

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
			/*
			Console.WriteLine("Лабораторная работа №9:");
			Console.WriteLine("2) Продемонстрировать вызов всех конструкторов");

			Teacher Teacher1 = new Teacher();
			Teacher Teacher2 = new Teacher("Сталин");
			Teacher Teacher3 = new Teacher("Жмышенко", "Василий", "Витальевич");

			Teacher1.OutputTeacher();
			Console.WriteLine();
			Teacher2.OutputTeacher();
			Console.WriteLine();
			Teacher3.OutputTeacher();
			Console.WriteLine("\n\n");

			Discipline Discipline1 = new Discipline();
			Discipline Discipline2 = new Discipline("Бориков");
			Discipline Discipline3 = new Discipline("Химия", Teacher3);

			Discipline1.OutputDiscipline();
			Console.WriteLine();
			Discipline2.OutputDiscipline();
			Console.WriteLine();
			Discipline3.OutputDiscipline();
			Console.WriteLine("\n\n");

			Mark Mark1 = new Mark();
			Mark Mark2 = new Mark(65);

			Mark1.OutputMark();
			Console.WriteLine();
			Mark2.OutputMark();
			Console.WriteLine("\n\n");

			Student Student1 = new Student();
			Student Student2 = new Student("Лупин");
			Student Student3 = new Student("Пупин", "Андрей", "Васильевич", Marks2, 3, Disciplines, 3);

			Student1.OutputStudent();
			Console.WriteLine();
			Student2.OutputStudent();
			Console.WriteLine();
			Student3.OutputStudent();
			Console.WriteLine("\n\n");

			Group Group1 = new Group();
			Group Group2 = new Group("ПИ-02");
			Group Group3 = new Group("ПИ-03", Students, 3);

			Group1.OutputGroup();
			Console.WriteLine();
			Group2.OutputGroup();
			Console.WriteLine();
			Group3.OutputGroup();
			Console.WriteLine("\n\n");

			Console.WriteLine("3) Инициализировать небольшой массив конструктором с одним параметром");
			Teacher[] teacherArr = new Teacher[3];
			for (int j = 0; j < 3; j++)
				teacherArr[j] = new Teacher("Иванов" + (j + 1));
			for (int j = 0; j < 3; j++)
				teacherArr[j].OutputTeacher();
			Console.WriteLine("\n\n");

			/*
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

			Console.WriteLine("13) Cоздать массив объектов и продемонстрировать работу с ним");
			Mark[][] MarkFor13 = new Mark[1][];
			MarkFor13[0] = new Mark[3];
			for (i = 0; i < 3; i++)
			{
				MarkFor13[0][i] = new Mark();
			}
			Console.Write("Массив баллов:\n");
			for (i = 0; i < 3; i++)
			{
				MarkFor13[0][i].Set(i*5 + 50);
				MarkFor13[0][i].OutputMark();
			}
			Console.WriteLine();

			Console.WriteLine("14) Продемонстрировать возврат значения через параметр out и через параметр ref. Показать различие этих механизмов");
			Console.Write("На примере структуры оценка\n");
			Mark markForRef = new Mark();
			Mark markForOut = new Mark();
			int ArgRef = 2;
			int ArgOut;
			markForRef.Set(1);
			markForRef.TestRef(ref ArgRef);
			Console.WriteLine("Аргумент функции после использования по ref: " + ArgRef);
			markForOut.Set(2);
			markForOut.TestOut(out ArgOut);
			Console.WriteLine("Аргумент функции после использования по out: " + ArgOut);
			Console.WriteLine();

			Console.WriteLine("15) Продемонстрировать разумное использование оператора this;");
			Mark A = new Mark();
			Mark B = new Mark();
			Mark C = new Mark();
			Mark D = new Mark();
			A.Set(10);
			B.Set(20);
			C.Set(30);
			D.Set(40);
			Mark.NewList();
			// Вызов статической компанентной функции:
			Mark.Reprint();
			// Включение созданных компанентов в двусвязанный список:
			A.Add(); B.Add(); C.Add(); D.Add();
			// Печать в обратном порядке значений элементов списка:
			Mark.Reprint();
			Console.WriteLine();

			Console.WriteLine("16) Продемонстрировать перегрузку операторов '+', '++'");
			Mark MarkPlus = new Mark();
			MarkPlus.Set(50);
			MarkPlus.OutputMark();
			Console.WriteLine("Оператор + (прибавим 10 баллов):");
			MarkPlus = MarkPlus + 10;
			MarkPlus.OutputMark();
			Console.WriteLine("Оператор ++ префиксный:");
			++MarkPlus;
			MarkPlus.OutputMark();
			Console.WriteLine("Оператор ++ постфиксный:");
			MarkPlus++;
			MarkPlus.OutputMark();
			Console.WriteLine();

			Console.WriteLine("17) Продемонстрировать обработку строк (string)");
			Teacher TeacherString = new Teacher();
			TeacherString.Set("", "", "");
			TeacherString.ShowingWorkingWithString();
			TeacherString.OutputTeacher();

			Console.WriteLine("Модифицировать ваши проекты на С++, C# и Java путем добавления в один из классов как минимум одного статического поля и одного статического метода.");
			Mark A = new Mark();
			Mark B = new Mark();
			Mark C = new Mark();
			Mark D = new Mark();
			A.Set(10);
			B.Set(20);
			C.Set(30);
			D.Set(40);
			Mark.NewList();
			// Вызов статической компанентной функции:
			Mark.Reprint();
			// Включение созданных компанентов в двусвязанный список:
			A.Add(); B.Add(); C.Add(); D.Add();
			// Печать в обратном порядке значений элементов списка:
			Mark.Reprint();
			Console.WriteLine();
			*/
		}
	}
}
