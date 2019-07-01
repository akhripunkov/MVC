using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Controllers
{
    class GetInfoController
    {
        public string Questinon(string msg)
        {
            Model model = new Model();
            return model.GetAnswer(msg);
        }

    }
}
