using System.ComponentModel.DataAnnotations;

namespace SMS1._0MasterServices.Models
{
    public class CommonMaster
    {
        [Required]
        public int CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        [Required]
        public bool Enabled { get; set; }
    }
}
