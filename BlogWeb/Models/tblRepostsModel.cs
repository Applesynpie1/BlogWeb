using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWeb.Models
{
    public class tblRepostsModel
    {
        public int repostID { get; set; }

        public int userID { get; set; }
        public int postID { get; set; }
        public string content { get; set; }
        public DateTime createAt { get; set; }
    }
}