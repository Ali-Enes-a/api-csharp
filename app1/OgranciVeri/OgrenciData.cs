using app1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace app1.OgranciVeri
{
    public class OgrenciData
    {

        public static List<Ogrenci> OgrenciList = new List<Ogrenci>()
        {

            new Ogrenci
            {
                Id = 1,
                Adi = "Ali Enes",
                Soyadi = "Eren",
                TcNo = 41698796323,
               BolumAdi = BolumVeri.BolumData.BolumList[0].Adi,
                FakulteAdi = BolumVeri.BolumData.BolumList[0].FakulteAdi

            }



        };

    }
}