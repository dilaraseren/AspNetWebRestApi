using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetWebRestApi.Models
{
    public class Context:DbContext
    {
        public DbSet<Weather> Weathers { get; set; }
        public DbSet<MyProfil> MyProfils { get; set; }
    }
}