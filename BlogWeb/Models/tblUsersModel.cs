using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWeb.Models
{
    public class tblUsersModel
    {
        public int userID { get; set; }
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public int phoneNum { get; set; }
        public DateTime birthday { get; set; }
        public string profilepic { get; set; }
        public string bio { get; set; }
        public string role { get; set; }
        public int otpStatus { get; set; }
        public int otp { get; set; }
        public DateTime createAt { get; set; }
        public DateTime updateAt { get; set; }
    }
}