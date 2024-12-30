using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERP_IMR.Models
{
    public class BSMIMRGEN003
    {
        [Key] // Primary Key
        [MaxLength(3)] // COUNTRYCODE'un VARCHAR(3) sınırı
        [Required]
        public string COUNTRYCODE { get; set; } // Ülke Kodu

        [ForeignKey("BSMIMRGEN001")] // Foreign Key
        [MaxLength(4)] // COMCODE'un VARCHAR(4) sınırı
        [Required]
        public string COMCODE { get; set; } // Firma Kodu

        [MaxLength(80)] // COUNTRYTEXT'un VARCHAR(80) sınırı
        [Required]
        public string COUNTRYTEXT { get; set; } // Ülke Adı
    }
}
