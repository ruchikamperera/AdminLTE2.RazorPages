using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AdminLTE2.Web.Model;

    public class QRAppContext : DbContext
    {
        public QRAppContext (DbContextOptions<QRAppContext> options)
            : base(options)
        {
        }

        public DbSet<AdminLTE2.Web.Model.Menu> Menu { get; set; }
    }
