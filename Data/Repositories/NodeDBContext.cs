using System.Data.Entity;
using Data.Repositories.Models;

namespace Data.Repositories
{
    public partial class NodeDBContext : DbContext
    {
        public NodeDBContext()
            : base("name=NODEDB")
        {

        }

        public virtual DbSet<NODES> Nodes { get; set; }
        public virtual DbSet<NODE_LINKS> Node_Links { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
