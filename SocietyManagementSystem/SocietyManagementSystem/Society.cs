﻿using System;
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
        public List<Complaint> Complaints {
            get {
                return complaints;
            }
        }
        public List<Complaint> SolvedComplaints {
            get {
                List<Complaint> solved = new List<Complaint>();
                foreach (var complaint in complaints) {
                    if (complaint.Status == "Solved") {
                        solved.Add(complaint);
                    }
                }
                return solved;
            }
        }
        public List<Complaint> PendingComplaints {
            get {
                List<Complaint> pending = new List<Complaint>();
                foreach (var complaint in complaints)
                {
                    if (complaint.Status == "Pending")
                    {
                        pending.Add(complaint);
                    }
                }
                return pending;
            }
        }
        private Society() {
            complaints = new List<Complaint>();
        }
        /// <summary>
        /// To get the singleton instance of Society class.
        /// </summary>
        /// <returns></returns>
        public static Society GetInstance() {
            if (__instance == null) {
                __instance = new Society();
            }
            return __instance;
        }
        public bool AddComplaint(Complaint c) {
            complaints.Add(c);
            return true;
        }

    }
}