using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M.Data
{
    public class Directory
    {
        public static string Dir()
        {
            string BaseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string[] BaseDirectory_list = BaseDirectory.Split('\\');
            string Directory = "";
            for (int a = 0; a < BaseDirectory_list.Count() - 4; a++)
            {
                Directory = Directory + BaseDirectory_list[a] + "\\";
            }
            Directory = Directory + "M\\Data\\";
            return Directory;
        }
    }
}
