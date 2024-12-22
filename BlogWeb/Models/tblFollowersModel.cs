using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWeb.Models
{
    public class tblFollowersModel
    {
        public int followerID { get; set; }
        public int userID { get; set; }
        public DateTime createAt { get; set; }
    }
}