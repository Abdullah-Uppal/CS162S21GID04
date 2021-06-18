using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocietyManagementSystem {
    /// <summary>
    /// This is the singleton society because this application 
    /// manages one society only.
    /// </summary>
    class Society {
        private static Society __instance = null;
        private List<Complaint> complaints;
        private Society() {
            complaints = new List<Complaint>();
        }
        /// <summary>
        /// To get the singleton instance of Society class.
        /// </summary>
        /// <returns></returns>
        public static Society GetInstance() {
            if (__instance == null) {
                return new Society();
            }
            return __instance;
        }
        public bool AddComplaint(Complaint c) {
            complaints.Add(c);
            MessageBox.Show(c.ToString());
            return true;
        } 

    }
}
