﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERP_IMR.Models
{
    public class BSMIMRROT001
    {
        [Key] // Primary Key
        [MaxLength(4)] // DOCTYPE'un VARCHAR(4) sınırı
        [Required] // Zorunlu alan
        public string DOCTYPE { get; set; } // Rota Tipi (Primary Key)

        [ForeignKey("BSMIMRGEN001")] // Foreign Key
        [MaxLength(4)] // COMCODE'un VARCHAR(4) sınırı
        [Required] // Zorunlu alan
        public string COMCODE { get; set; } // Firma Kodu (Foreign Key)

        [MaxLength(80)] // DOCTYPETEXT'un VARCHAR(80) sınırı
        [Required] // Zorunlu alan
        public string DOCTYPETEXT { get; set; } // Rota Tipi Açıklaması

        [Required] // Zorunlu alan
        public bool ISPASSIVE { get; set; } // Pasif Mi? (0: Hayır, 1: Evet)

        
    }
}
