using System.ComponentModel.DataAnnotations;

namespace SMS1._0MasterServices.Models
{
    public class Product:CommonMaster
    {
        [Key]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int CategoryId  { get; set; }
        public string? Description { get; set; }
        
    }
}
