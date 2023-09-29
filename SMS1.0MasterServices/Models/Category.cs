using System.ComponentModel.DataAnnotations;

namespace SMS1._0MasterServices.Models
{
    public class Category : CommonMaster
    {
        [Key]
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
        
    }
}
