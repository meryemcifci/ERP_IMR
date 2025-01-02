using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Emit;

namespace ERP_IMR.ViewModels
{
    public class MaliyetViewModel
    {
        public string COMCODE { get; set; }
        public string CCMDOCTYPE { get; set; }
        public string CCMDOCNUM { get; set; }
        public DateTime CCMDOCFROM { get; set; }
        public DateTime CCMDOCUNTIL { get; set; }
        public string MAINCCMDOCTYPE { get; set; }
        public string MAINCCMDOCNUM { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISPASSIVE { get; set; }
        public string CCMSTEXT { get; set; } 


    }
}
