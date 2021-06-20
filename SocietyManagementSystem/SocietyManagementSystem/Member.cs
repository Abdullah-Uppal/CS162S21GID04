using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyManagementSystem
{
    class Member : Person
    {
        /// <summary>
        /// Members have different ages
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Members have different designation
        /// </summary>
        public String designation { get; set; }
        /// <summary>
        /// Members have different Address
        /// </summary>
        public String Address { get; set; }
    }
}
