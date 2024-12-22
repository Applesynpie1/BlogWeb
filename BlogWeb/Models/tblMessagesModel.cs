using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogWeb.Models
{
    public class tblMessagesModel
    {
        public int messageID { get; set; }

        public int senderID { get; set; }

        public int receiverID { get; set; }
        public string content { get; set; }
        public DateTime createAt { get; set; }
    }
}