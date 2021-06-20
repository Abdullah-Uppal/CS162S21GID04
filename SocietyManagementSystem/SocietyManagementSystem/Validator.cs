using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SocietyManagementSystem {
    class Validator {
        public static bool ValidateName(string name) {
            foreach(var x in name)
                if (x != ' ' || !Char.IsLetter(x)) {
                    return false;
                }
            return true;
        }
        public static bool ValidateCnic(string cnic) {
            if (cnic.Length != 13) return false;
            foreach(var x in cnic) {
                if (!char.IsDigit(x)) {
                    return false;
                }
            }
            return true;
        }
        public static bool ValidateEmail(string email) {
            string[] arr = email.Split('@');
            if (arr.Length != 2) return false;
            //Validating username part 
            int len = arr[0].Length;
            string username = arr[0];
            if (char.IsLetter(username[0]) && char.IsLetterOrDigit(username[len-1])) {
                
            }
            return true;
        }
    }
}
