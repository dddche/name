using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace mygame
{
    static class Reader //класс для считывания значений из файла
    {

        static public int[] read(string path)
        {
            string[] file = File.ReadAllText(path).Split(',');
            int[] ret = new int[file.Length];
            for (int i = 0; i < ret.Length; i++)
            {
                ret[i] = Convert.ToInt32(file[i]);
            }
            return ret;



        }
    }
}
