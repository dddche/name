using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mygame
{
    class Game
    {
        public int[,] field;
        public Game(int[] gets)//первый конструктор 
        {

            if (canwedo(gets)) //проверяем может ли из такого массива создать игру
            {
                //если да то преобразуем поступивший массив(он пока одномерный) в двумерный(поле нашего класса field)
                int temp = 0;
                field = new int[Convert.ToInt32(Math.Sqrt(gets.Length)), Convert.ToInt32(Math.Sqrt(gets.Length))];
                for (int i = 0; i < Math.Sqrt(gets.Length); i++)
                {
                    for (int j = 0; j < Math.Sqrt(gets.Length); j++)
                    {
                        field[i, j] = gets[temp];
                        temp++;
                    }
                }

            }
            else
            {
                throw new Exception(); //если массив не подходил, то создаем иссключение
            }
        }




        public int this[int x, int y] //индексатор позволяет напрямую обращаться к полю класса, используется в классе reader
        {
            get { return field[x, y]; }

        }

        public virtual bool Shift(int val) //переставляем значения
        {
            int i1 = 0;
            int j1 = 0;
            int i2 = 0;
            int j2 = 0;
            for (int i = 0; i < Math.Sqrt(field.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(field.Length); j++)
                {
                    if (field[i, j] == 0)
                    {
                        i1 = i;
                        j1 = j;
                    }
                    if (field[i, j] == val)
                    {
                        i2 = i;
                        j2 = j;
                    }
                }
            }
            if ((Math.Abs(i2 - i1) + Math.Abs(j2 - j1)) == 1) //проверяем возможно ли поменять нужную цифру с 0,используем для этого разница между координатами(она должна быть равна 1)
            {
                field[i1, j1] = val;
                field[i2, j2] = 0;
                return true;
            }
            else
            {
                return false;
            }
        }



        protected bool canwedo(int[] gets)//проверка на то, что массив нам подходит(содержит только один 0, из него можно создать квадрат)
        {
            bool ret = true;
            int gameline = (int)Math.Sqrt(gets.Length);
            if (gameline % 1 == 0)
            {
                int zerocount = 0;
                for (int i = 0; i < 1; i++)
                {
                    for (int j = 1; j < gets.Length; j++)
                    {
                        if (gets[i] == gets[j])
                        {
                            ret = false;
                        }
                    }
                }
                foreach (var item in gets)
                {
                    if (item == 0)
                    {
                        zerocount++;
                    }
                }
                if (zerocount > 1 || zerocount == 0)
                {
                    ret = false;
                }
            }
            else
            {
                ret = false;
            }
            return ret;
        }
        }
}
