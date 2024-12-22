using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogWeb.Models
{
    public class tblPostsMap : EntityTypeConfiguration<tblPostsModel>
    {
        public tblPostsMap()
        {
            HasKey(i => i.postID);
            ToTable("poststbl");
        }
    }

}