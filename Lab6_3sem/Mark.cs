using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6_3sem
{
    public struct Mark
    {
        private int Number;
        public Mark(int Value)
        {
            Number = Value;
        }
        public int Get()
        {
            return Number;
        }
        public void Set(int M)
        {
            Number = M;
        }
        public void InputMark()
        {
            this.Set(0);
            Console.Write("Введите балл: ");
            Number = Convert.ToInt32(Console.ReadLine());
        }
        public void OutputMark()
        {
            Console.Write("Балл: " + Number + "\n");
        }
    }
}
