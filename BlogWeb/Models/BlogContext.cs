using BlogWeb.Models;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogWeb.Models
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BlogContext : DbContext
    {
        static BlogContext()
        {
            Database.SetInitializer<BlogContext>(null);
        }
        public BlogContext() : base("Name = blogdb")
        {

        }
        public virtual DbSet<tblCommentsModel> commentstbl { get; set; }
        public virtual DbSet<tblFollowersModel> followerstbl { get; set; }
        public virtual DbSet<tblLikesModel> likestbl { get; set; }
        public virtual DbSet<tblMessagesModel> messagestbl { get; set; }

        public virtual DbSet<tblPostsModel> poststbl { get; set; }

        public virtual DbSet<tblRepostsModel> repoststbl { get; set; }
        public virtual DbSet<tblUsersModel> userstbl { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new tblCommentsMap());
            modelBuilder.Configurations.Add(new tblFollowersMap());
            modelBuilder.Configurations.Add(new tblLikesMap());
            modelBuilder.Configurations.Add(new tblMessagesMap());
            modelBuilder.Configurations.Add(new tblPostsMap());
            modelBuilder.Configurations.Add(new tblRepostsMap());
            modelBuilder.Configurations.Add(new tblUsersMap());
        }
    }
}