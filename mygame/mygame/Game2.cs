using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mygame
{
    class Game_2 : Game
    {
        public Game_2(int[] gets) : base(gets)//наследуем конструктор из превого
        {
            randomi(gets);//рандомизируем список чисел
        }
        protected void randomi(int[] gets)
        {
            Random gen = new Random();
            for (int i = 0; i < gets.Length - 1; i++)
            {
                int t1 = gen.Next(gets.Length);
                int t2 = gen.Next(gets.Length);
                int temp = gets[i];
                gets[i] = gets[i + 1];
                gets[i + 1] = temp;
            }
        }
        public bool WIN() //проверка на то выйграна ли игра
        {
            bool status = true;
            int[] temper = new int[field.Length];
            int temp = 0;
            foreach (var item in field)
            {
                temper[temp] = item;
                temp++;
            }
            for (int i = 0; i < temper.Length - 1; i++)
            {
                if ((i != temper.Length - 2) && (temper[i] > temper[i + 1]))
                {
                    status = false;
                }
                if (temper[temper.Length - 1] != 0)
                {
                    status = false;
                }
            }
            return status;
        }
    }
}
