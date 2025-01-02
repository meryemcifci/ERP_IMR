using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ERP_IMR.ViewModels
{
    public class İşMerkeziViewModel
    {
      
        public string COMCODE { get; set; }
        public string WCMDOCTYPE { get; set; }
        public string WCMDOCNUM { get; set; }
        public DateTime WCMDOCFROM { get; set; }
        public DateTime WCMDOCUNTIL { get; set; }
        public string MAINWCMDOCTYPE { get; set; }
        public string MAINWCMDOCNUM { get; set; }
        public string CCMDOCTYPE { get; set; }
        public string CCMDOCNUM { get; set; }
        public string WORKTIME { get; set; }
        public bool ISDELETED { get; set; }
        public bool ISPASSIVE { get; set; }
        public string WCMSTEXT { get; set; }
        public string OPRDOCTYPE { get; set; }


    }
}
