using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERP_IMR.Models
{
        public class BSMIMRMATHEAD
        {
            [ForeignKey("BSMIMRGEN001")] // Foreign Key
            [MaxLength(4)] // VARCHAR(4)
            [Required] // Zorunlu alan
            public string COMCODE { get; set; } // Firma Kodu

           

            [ForeignKey("BSMIMRMAT001")]
            [MaxLength(4)] // VARCHAR(4)
            [Required] // Zorunlu alan
            public string MATDOCTYPE { get; set; } // Malzeme Tipi


            [Key] // Primary Key
            [MaxLength(25)] // VARCHAR(25)
            [Required] // Zorunlu alan
            public string MATDOCNUM { get; set; } // Malzeme Kodu

            [Required] // Zorunlu alan
            public DateTime MATDOCFROM { get; set; } // Geçerlilik Başlangıç (Alternatif Anahtar)

            [Required] // Zorunlu alan
            public DateTime MATDOCUNTIL { get; set; } // Geçerlilik Bitiş (Alternatif Anahtar)

            [Required]
            public int SUPPLYTYPE { get; set; } // Tedarik Tipi (0: Satınalınan, 1: Üretilen)

            [MaxLength(3)]
            [Required]
            public string STUNIT { get; set; } // Malzeme Stok Birimi

            public decimal? NETWEIGHT { get; set; } // Net Ağırlık (Optional)

            [MaxLength(3)]
            public string NWUNIT { get; set; } // Net Ağırlık Birimi

            public decimal? BRUTWEIGHT { get; set; } // Brüt Ağırlık (Optional)

            [MaxLength(3)]
            public string BWUNIT { get; set; } // Brüt Ağırlık Birimi

            public bool ISBOM { get; set; } // Ürün Ağacı Var Mı? (0: Hayır, 1: Evet)

            [MaxLength(4)]
            public string BOMDOCTYPE { get; set; } // Ürün Ağacı Tipi

            [MaxLength(25)]
            public string BOMDOCNUM { get; set; } // Ürün Ağacı Kodu

            public bool ISROUTE { get; set; } // Rota Var Mı? (0: Hayır, 1: Evet)

            [MaxLength(4)]
            public string ROTDOCTYPE { get; set; } // Rota Tipi

            [MaxLength(25)]
            public string ROTDOCNUM { get; set; } // Rota Tipi

            public bool ISDELETED { get; set; } // Silindi Mi? (0: Hayır, 1: Evet)

            public bool ISPASSIVE { get; set; } // Pasif Mi? (0: Hayır, 1: Evet)
        }
}

