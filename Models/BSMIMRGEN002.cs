using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_IMR.Models
{
    public class BSMIMRGEN002
    {
        [MaxLength(4)]
        [Required]
        [ForeignKey("BSMIMRGEN001")]
        public string COMCODE { get; set; } // Firma Kodu (Key, Not Null)

        [Key]
        [MaxLength(3)]
        [Required]
        public string LANCODE { get; set; } // Dil Kodu (Key, Not Null)

        [MaxLength(80)]
        [Required]
        public string LANTEXT { get; set; } // Dil Adı (Nullable)
    }
}
