using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_3sem
{
    public class Mark
    {
        private int Number = 0;
        private static Mark last_mark; // Адрес последнего элемента списка
        private Mark prev; // На предыдущий элемент списка
        private Mark next; // На следующий элемент списка

        public Mark()
        {
            Number = 0;
        }
        public Mark(int M)
        {
            Number = M;
            if (IsRightMark(M))
                Number = M;
        }
        public int Get()
        {
            return Number;
        }
        public void Set(int M)
        {
            Number = 0;
            if (IsRightMark(M))
                Number = M;
        }
        public void InputMark()
        {
            string mark;
            Console.Write("Введите балл: ");
            mark = Console.ReadLine();
            // ищем исключения внутри этого блока и отправляем их в соответствующий обработчик catch
            try
            {
                for (int i = 0; i < mark.Length; i++)
                {
                    if ((mark[i] < '0') || (mark[i] > '9'))
                        throw new Exception("It string is not number!"); // выбрасывается исключение
                }
                Set(Convert.ToInt32(mark));
            }
            catch (Exception ex) // обработчик исключений типа const char*
            {
                Console.Write("Error: " + ex.Message + '\n');
            }
        }
    
        public void OutputMark()
        {
            Console.Write("Балл: " + Number + "\n");
        }
        public void TestRef(ref int N)
        {
            N = 4;
        }
        public void TestOut(out int N)
        {
            N = 5;
        }

        public static void NewList()
        {
            last_mark = null;
        }

        // Добавление элемента в конец списка
        public void Add()
        {
            if (last_mark == null)
                this.prev = null;
            else
            {
                last_mark.next = this;
                prev = last_mark;
            }
            last_mark = this;
            this.next = null;
        }

        // Вывод на дисплей содержимого списка
        public static void Reprint()
        {
            Mark uk;   // Вспомогательный указатель
            uk = last_mark;
            if (uk == null)
            {
                Console.Write("Список пуст!");
                return;
            }
            else
                Console.Write("\nСодержимое списка:\n");

            // Цикл печати в обратном порядке значений элементов списка:
            while (uk != null)
            {
                Console.Write(uk.Number + "\t");
                uk = uk.prev;
            }
        }

        public static Mark operator +(Mark mark, int number)
        {
            if (mark.Number + number > 100)
                return mark;
            else
            {
                Mark temp = new Mark();
                temp.Set(mark.Number + number);
                return temp;
            }
        }

        public static Mark operator ++(Mark mark)
        {
            if (mark.Number + 1 > 100)
                return mark;
            else
            {
                Mark temp = new Mark();
                temp.Set(mark.Number + 1);
                return temp;
            }
        }

        // Проверка числа на подходяее для оценки
        public bool IsRightMark(int mark)
        {
            bool res = true;
            try // ищем исключения внутри этого блока и отправляем их в соответствующий обработчик catch
            {
                if (mark < 0 || mark > 100) // Если пользователь ввел неверное число, то выбрасывается исключение
                    throw new Exception("Incorrect value."); // выбрасывается исключение типа const char*
                return res;
            }
            catch (Exception ex) // обработчик исключений типа const char*
            {
                Console.WriteLine("Error: " + ex.Message + '\n');
                res = false;
                return res;
            }
        }
    }
}
