using app1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app1.FakulteVeri
{
    public class FakulteData
    {
        public static List<Fakulte> FakulteList = new List<Fakulte>()
        {


            new Fakulte
            {

                Id = 1,
                Adi = "Mühendislik Fakültesi"

            },
                new Fakulte
                {
                    Id = 2,
                    Adi = "Eczacılık Fakültesi"

                }

        };
            

    }
}