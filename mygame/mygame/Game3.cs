using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mygame
{
    class Game_3 : Game_2
    {
        public readonly List<int> history; //readonly чтобы ничего не присваивалось history
        public Game_3(int[] gets) : base(gets)//наследуем конструктор из второго
        {
            history = new List<int>();//инциализируем список движений
        }

        public void addhistory(int val)
        {
            history.Add(val);
        }
        public override bool Shift(int val)
        //используем override, чтобы  базовому функционалу добавить запись истории из Game
        {
            if (base.Shift(val)) //проверка можно ли сдвинуть 
            {
                base.Shift(val);
                try { addhistory(val); }
                catch { }
            }
            return base.Shift(val);
        }
        public void goback() //делаем откат на шаг назад
        {
            Shift(history.Last());
        }
    }
}
