using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogWeb.Models
{
    public class tblMessagesMap : EntityTypeConfiguration<tblMessagesModel>
    {
        public tblMessagesMap()
        {
            HasKey(i => i.messageID);
            ToTable("messagestbl");
        }
    }

}