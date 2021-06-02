using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyManagementSystem
{
    class Building
    {
        private String address;

        private String size;

        public String GetAddress
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }
        public String GetSize
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
            }
        }
    }
}
