using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ERP_IMR.Models
{
    public class BSMIMRGEN004
    {
        [Key] // Primary Key
        [MaxLength(3)] // CITYCODE'un VARCHAR(3) sınırı
        [Required]
        public string CITYCODE { get; set; } // Şehir Kodu (Primary Key)

        [ForeignKey("BSMIMRGEN001")] // Foreign Key
        [MaxLength(4)] // COMCODE'un VARCHAR(4) sınırı
        [Required]
        public string COMCODE { get; set; } // Firma Kodu (Foreign Key)

        [MaxLength(80)] // CITYTEXT'un VARCHAR(80) sınırı
        [Required]
        public string CITYTEXT { get; set; } // Şehir Adı (Nullable)

        [ForeignKey("BSMIMRGEN003")]
        [MaxLength(3)] 
        [Required]
        public string COUNTRYCODE { get; set; } 
    }
}
