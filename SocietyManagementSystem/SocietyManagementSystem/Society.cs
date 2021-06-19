using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.IO;
using System.Windows.Forms;

namespace SocietyManagementSystem {
    /// <summary>
    /// This is the singleton society because this application 
    /// manages one society only.
    /// </summary>
    class Society {
        [JsonIgnore]
        private static Society __instance = null;
        public List<Complaint> complaints;
        public void SaveData() {
            File.WriteAllText("../../data.json", JsonSerializer.Serialize(this, new JsonSerializerOptions() { WriteIndented = true }));
        }

        public static void SetInstance(Society value) {
            __instance = value;
        }

        public List<Complaint> Complaints {
            get {
                return complaints;
            }
            set{
                complaints = value;
            }
        }
        [JsonIgnore]
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
        [JsonIgnore]
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
        public Society() {
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
    class Loader {

        public static void LoadData() {
            Society.SetInstance(JsonSerializer.Deserialize<Society>(File.ReadAllText("../../data.json")));
        }
    }
}