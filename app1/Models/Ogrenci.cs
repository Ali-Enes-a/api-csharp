using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace app1.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        [DisplayName ("Öğrenci Adı :")]

        public string Adi { get; set; }
        [DisplayName ("Öğrenci Soyadı :")]
        public string Soyadi { get; set; }
       
        [DisplayName ("TC No :")]
        public long TcNo { get; set; }

        [DisplayName ("Bölümü :")]
        public string BolumAdi { get; set; }


        public virtual Bolum Bolumu { get; set; }

        [DisplayName("Fakültesi :")]
        public string FakulteAdi { get; set; }
        public virtual Fakulte Fakultesi { get; set; }

    }
}