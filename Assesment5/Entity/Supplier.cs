using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assesment5.Entity
{
    public class Supplier
    {
        [Key]
        [Required]
        public int SupplierId { get; set; }
        [Required]
        [Column(TypeName =("VARCHAR"))]
        [MaxLength(50)] 
        public string SupplierName { get; set; }
        [Required]
        [Column(TypeName = ("VARCHAR"))]
        [MaxLength(50)]
        [ForeignKey("PurchaseOrder")]
        public string Destination { get; set; }

        //
        public PurchaseOrder PurchaseOrders { get; set; }
    }
}
