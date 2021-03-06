using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ridly.Models
{
    public class category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        public int DisplayOrder { get; set; }
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}

