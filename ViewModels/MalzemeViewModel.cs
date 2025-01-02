namespace ERP_IMR.ViewModels
{
    public class MalzemeViewModel
    {
      
        public string COMCODE { get; set; } // Firma Kodu
       
        public string MATDOCTYPE { get; set; } // Malzeme Tipi

        public string MATDOCNUM { get; set; } // Malzeme Kodu

        public DateTime MATDOCFROM { get; set; } // Geçerlilik Başlangıç (Alternatif Anahtar)

        public DateTime MATDOCUNTIL { get; set; } // Geçerlilik Bitiş (Alternatif Anahtar)

        public int SUPPLYTYPE { get; set; } // Tedarik Tipi (0: Satınalınan, 1: Üretilen)
      
        public string STUNIT { get; set; } // Malzeme Stok Birimi

        public decimal? NETWEIGHT { get; set; } // Net Ağırlık (Optional)

        public string NWUNIT { get; set; } // Net Ağırlık Birimi

        public decimal? BRUTWEIGHT { get; set; } // Brüt Ağırlık (Optional)

        public string BWUNIT { get; set; } // Brüt Ağırlık Birimi

        public bool ISBOM { get; set; } // Ürün Ağacı Var Mı? (0: Hayır, 1: Evet)

        public string BOMDOCTYPE { get; set; } // Ürün Ağacı Tipi

        public string BOMDOCNUM { get; set; } // Ürün Ağacı Kodu

        public bool ISROUTE { get; set; } // Rota Var Mı? (0: Hayır, 1: Evet)

        public string ROTDOCTYPE { get; set; } // Rota Tipi

        public string ROTDOCNUM { get; set; } // Rota KODU

        public bool ISDELETED { get; set; } // Silindi Mi? (0: Hayır, 1: Evet)

        public bool ISPASSIVE { get; set; } // Pasif Mi? (0: Hayır, 1: Evet)

        public string LANCODE { get; set; }

        public string MATSTEXT { get; set; } // Malzeme Kısa Açıklaması

        public string MATLTEXT { get; set; } // Malzeme Uzun Açıklaması
    }
}
