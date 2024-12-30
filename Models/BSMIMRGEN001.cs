using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERP_IMR.Models
{
    public class BSMIMRGEN001
    {
        [Key]
        [MaxLength(4)]
        [Required]
        public string COMCODE { get; set; } // Firma Kodu (Key, Not Null)

        [MaxLength(80)]
        [Required]
        public string COMTEXT { get; set; } // Firma Adı (Not Null)

        [MaxLength(80)]
        public string ADDRESS1 { get; set; } // Firma Adresi-1 (Nullable)

        [MaxLength(80)]
        public string ADDRESS2 { get; set; } // Firma Adresi-2 (Nullable)

        [MaxLength(3)]
        [ForeignKey("BSMIMRGEN004")]
        public string CITYCODE { get; set; } // Şehir Kodu (Nullable)

        [MaxLength(3)]
        [ForeignKey("BSMIMRGEN003")]
        public string COUNTRYCODE { get; set; } // Ülke Kodu (Nullable)
    }
}
