using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace SocietyManagementSystem {
    /// <summary>
    /// This is the singleton society because this application 
    /// manages one society only.
    /// </summary>
    class Society {
        [JsonIgnore]
        private static Society __instance = null;
        [JsonIgnore]
        public List<Complaint> complaints;
        [JsonIgnore]
        public List<Person> member;
        public void SaveData() {
            JsonSerializer j = new JsonSerializer() { Formatting = Formatting.Indented };
            using (var sw = new StreamWriter("../../data.json"))
            using (JsonWriter writer = new JsonTextWriter(sw)) {
                j.Serialize(writer, __instance);
            }
        }

        public static void SetInstance(Society value) {
            __instance = value;
        }

        public List<Complaint> Complaints {
            get {
                return complaints;
            }
            set {
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
                foreach (var complaint in complaints) {
                    if (complaint.Status == "Pending") {
                        pending.Add(complaint);
                    }
                }
                return pending;
            }
        }
        public Society() {
            complaints = new List<Complaint>();
            member = new List<Person>();
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
        public bool AddMember(Member m) {
            member.Add(m);
            return true;
        }
        public List<Person> Member {
            get {
                return member;
            }
            set {
                member = value;
            }
        }
    }
    class Loader {

        public static void LoadData() {
            JsonSerializer j = new JsonSerializer() { Formatting = Formatting.Indented };
            try {
                using (var sw = new StreamReader("../../data.json")) {
                    using (var reader = new JsonTextReader(sw)) {
                        Society.SetInstance(j.Deserialize<Society>(reader));
                    }
                }
            }
            catch {

            }
        }
    }
}