using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace BlogWeb.Models
{
    public class tblLikesMap : EntityTypeConfiguration<tblLikesModel>
    {
        public tblLikesMap()
        {
            HasKey(i => i.likeID);
            ToTable("likestbl");
        }
    }

}