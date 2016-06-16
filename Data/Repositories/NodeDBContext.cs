﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Repositories.Models;

namespace Data.Repositories
{
    public partial class NodeDBContext : DbContext
    {
        public NodeDBContext()
            : base("name=NODEDB")
        {

        }

        public virtual DbSet<NODE> Nodes { get; set; }
        public virtual DbSet<NODE_LINKS> Node_Links { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
