using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogWeb.Models
{ 
        public class tblCommentsMap : EntityTypeConfiguration<tblCommentsModel>
        {
            public tblCommentsMap()
            {
                HasKey(i => i.commentID);
                ToTable("commentstbl");
            }
        }

}
