using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assesment5.Entity
{
    public class Item
    {
        [Key]
        [Required]
        public int ItemId { get; set; }
        [Required]
        [Column(TypeName =("Varchar"))]
        [MinLength(2)]
        public string ItemName { get; set; }
        public int Price { get; set; }
        public int Stock {  get; set; }
    }
}
