using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogWeb.Models
{
    public class tblFollowersMap : EntityTypeConfiguration<tblFollowersModel>
    {
        public tblFollowersMap()
        {
            HasKey(i => i.followerID);
            ToTable("followerstbl");
        }
    }

}