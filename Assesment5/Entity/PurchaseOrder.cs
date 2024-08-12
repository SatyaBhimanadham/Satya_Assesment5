using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assesment5.Entity
{
    public class PurchaseOrder
    {
        [Key]
        [Required]
        public int OrderId { get; set; }
        [ForeignKey("Item")]
        public int ItemId { get; set; }
        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        [Required]
        [Column(TypeName =("varchar"))]
        [StringLength(50)]
        public string Destination { get; set; }

        //nav
        public Item Items { get; set; }
        public Supplier Suppliers { get; set; }
    }
}
