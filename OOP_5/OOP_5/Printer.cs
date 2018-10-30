using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_5
{
    class Printer
    {

        public string iAmPrintig(Object obj)
        {
            string type = Convert.ToString(obj.GetType());
            return type;
            
        }

        

    }
}
