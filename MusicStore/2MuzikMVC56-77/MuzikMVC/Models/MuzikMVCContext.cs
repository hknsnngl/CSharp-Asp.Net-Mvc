using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MuzikMVC.Models
{
    public class MuzikMVCContext : DbContext
    {
        public DbSet<Album>Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public System.Data.Entity.DbSet<MuzikMVC.Models.Artist> Artists { get; set; }
    }

}