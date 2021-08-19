using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app1.Models
{
    public class Fakulte
    {

        public int Id { get; set; }

        public string Adi { get; set; }

        public ICollection<Bolum> Bolumler { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}