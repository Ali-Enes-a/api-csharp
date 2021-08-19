using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace app1.Models
{
    public class Bolum
    {

        public int Id { get; set; }

        [DisplayName("Bölüm Adı :")]
        public string Adi { get; set; }

        [DisplayName("Fakültesi :")]
        public string FakulteAdi { get; set; }
        public virtual Fakulte Fakultesi { get; set; }

        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}