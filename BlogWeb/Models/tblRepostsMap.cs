using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogWeb.Models
{
    public class tblRepostsMap : EntityTypeConfiguration<tblRepostsModel>
    {
        public tblRepostsMap()
        {
            HasKey(i => i.repostID);
            ToTable("repoststbl");
        }
    }

}