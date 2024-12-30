using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_IMR.Models
{
    public class BSMIMRGEN005
    {
        [Key] // Primary Key
        [MaxLength(3)] // UNITCODE'un VARCHAR(3) sınırı
        [Required]
        public string UNITCODE { get; set; } // Birim Kodu (Primary Key)

        [ForeignKey("BSMIMRGEN001")] // Foreign Key
        [MaxLength(4)] // COMCODE'un VARCHAR(4) sınırı
        [Required]
        public string COMCODE { get; set; } // Firma Kodu (Foreign Key)

        [MaxLength(80)] // UNITTEXT'un VARCHAR(80) sınırı
        [Required]
        public string UNITTEXT { get; set; } // Birim Adı (Nullable)

        public bool ISMAINUNIT { get; set; } // Ana Ağırlık Birimi (0: Hayır, 1: Evet)

        [MaxLength(3)] 
        public string MAINUNITCODE { get; set; } // Ana Birim Kodu (Nullable)
    }
}
