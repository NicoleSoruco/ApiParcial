using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ParcialNicoleSoruco.Models
{
    public class DataContext:DbContext
    {
        public DataContext():base ("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<ParcialNicoleSoruco.Models.Soruco> Sorucoes { get; set; }
    }
}