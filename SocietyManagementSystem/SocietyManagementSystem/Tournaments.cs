﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyManagementSystem
{
     class Tournaments : Event
    {
        private String location;

        private String matches;

        public String GetLocation
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }
        public String GetMatch
        {
            get
            {
                return matches;
            }
            set
            {
                matches = value;
            }
        }
    }
}
