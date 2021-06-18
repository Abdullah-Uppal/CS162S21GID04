using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocietyManagementSystem
{
    class Event
    {
        //private String event_name;
        private DateTime event_time;
        
        
        /// <summary>
        /// Get Event Name
        /// </summary>
        public String GetEventName { get; set; }
        /// <summary>
        /// Get Event Time
        /// </summary>
        public DateTime GetEventTime {
            get
            {
                return event_time;
            }
            set
            {
                event_time = value;
            }
        }
    }
}
