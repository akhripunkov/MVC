using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class Database
    {
        public static string GetAnswer(string question) {

            string path = @"Tables/Books.txt"; //путь к БД
            using (StreamReader sr = new StreamReader(path, Encoding.Default))
            {
                string str = null;

                while (true)
                {
                    str = sr.ReadLine();
                    if (str != null)
                    {
                        if (str == question)
                        {
                            return question + " есть в наличии";
                        }
                    }
                    else
                        return question + " нет в наличии";
                }

            }
            
        }
    }
}
