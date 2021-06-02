using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyManagementSystem
{
    class Bakery:Building
    {
        private String name;

        private int total;

        public String GetName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public int GetTotal
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }
    }
}
