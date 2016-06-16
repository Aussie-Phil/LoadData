namespace Data.Repositories.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NODES")]
    public partial class NODES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NODES()
        {
            NODE_LINKS = new HashSet<NODE_LINKS>();
            //NODE_LINKS1 = new HashSet<NODE_LINKS>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NODE_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string NODE_LABEL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NODE_LINKS> NODE_LINKS { get; set; }

       //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<NODE_LINKS> NODE_LINKS1 { get; set; }
    }
}
