namespace Data.Repositories.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class NODE_LINKS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NODE_LINKS_ID { get; set; }

        public int NODE_ID { get; set; }

        public int ADJACENT_NODE_ID { get; set; }

        public virtual NODE NODE { get; set; }

        public virtual NODE NODE1 { get; set; }
    }
}
