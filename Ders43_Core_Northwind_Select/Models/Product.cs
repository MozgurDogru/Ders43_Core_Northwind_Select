using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ders43_Core_Northwind_Select.Models
{
    public class Product
    {
        //set primary key,identity= yes
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductID { get; set; }
        [Required]
        public string? ProductName { get; set; }

        public decimal UnitPrice { get; set; }
    }
}
