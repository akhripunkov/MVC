using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class Model
    {
        public string GetAnswer(string question)
        {
            return Database.GetAnswer(question);
        }

    }
}
