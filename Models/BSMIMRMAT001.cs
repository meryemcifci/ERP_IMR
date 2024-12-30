using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERP_IMR.Models
{
    public class BSMIMRMAT001
    {
        [Key] // Primary Key
        [MaxLength(4)] // DOCTYPE'un VARCHAR(4) sınırı
        [Required]
        public string DOCTYPE { get; set; } // Malzeme Tipi (Primary Key)

        [ForeignKey("BSMIMRGEN001")] // Foreign Key
        [MaxLength(4)] // COMCODE'un VARCHAR(4) sınırı
        [Required]
        public string COMCODE { get; set; } // Firma Kodu (Foreign Key)

        [MaxLength(80)] // DOCTYPETEXT'un VARCHAR(80) sınırı
        [Required] // Zorunlu Alan
        public string DOCTYPETEXT { get; set; } // Malzeme Tipi Açıklaması

        public bool ISPASSIVE { get; set; } // Pasif Mi? (0: Hayır, 1: Evet)

        
    }
}
