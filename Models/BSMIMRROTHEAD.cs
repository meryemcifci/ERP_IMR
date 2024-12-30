using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace ERP_IMR.Models
{
    public class BSMIMRROTHEAD
    {


        [ForeignKey("BSMIMRGEN001")] // Firma Kodu
        [MaxLength(4)] // VARCHAR(4)
        [Required]
        public string COMCODE { get; set; }

       
        [MaxLength(4)]
        [Required]
        public string ROTDOCTYPE { get; set; }
       
        [Key]
        [MaxLength(25)] // VARCHAR(25)
        [Required]
        public string ROTDOCNUM { get; set; }

        [MaxLength(10)] // VARCHAR(10)
        [Required]
        public DateTime ROTDOCFROM { get; set; }

        [MaxLength(10)] // VARCHAR(25)
        [Required]
        public DateTime ROTDOCUNTIL { get; set; }

        [ForeignKey("BSMIMRMAT001")]
        [MaxLength(4)] // VARCHAR(10)
        [Required]
        public string MATDOCTYPE { get; set; }

        [ForeignKey("BSMIMRMAT001")]
        [MaxLength(25)] // VARCHAR(10)
        [Required]
        public string MATDOCNUM { get; set; }

        [MaxLength(5)]
        [Required]
        public decimal QUANTITY { get; set; }

        public bool ISDELETED { get; set; }

        public bool ISPASSIVE { get; set; }

        [MaxLength(25)]
        public string DRAWNUM { get; set; }



    }
}
