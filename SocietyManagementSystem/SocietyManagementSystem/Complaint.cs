using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SocietyManagementSystem {
    class Complaint {
        /// <summary>
        /// A complaint can either be Solved or Pending
        /// </summary>
        public string Status { get; set; }
        /// <summary>
        /// The Name of the complaint for quick idea.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The details of the Complaint
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The date and time at which the complaint were noted.
        /// </summary>
        public DateTime Date { get; set; }
        /// <summary>
        /// Name of the person who is complaining about something
        /// </summary>
        public string ComplainantName { get; set; }
        /// <summary>
        /// The Email of the complainant
        /// </summary>
        public string ComplainantEmail { get; set; }
        /// <summary>
        /// For a clean view we use json format
        /// </summary>
        /// <returns></returns>
        public override string ToString() {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions() { WriteIndented = true});
        }
    }
}
