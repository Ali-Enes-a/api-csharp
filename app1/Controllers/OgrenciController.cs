using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using app1.OgranciVeri;
using app1.Models;

namespace app1.Controllers
{   
    public class OgrenciController : Controller
    {
        // GET: Ogrenci
        public ActionResult OgrenciListele()
        {
            return View(OgrenciData.OgrenciList);
        }

        // GET: Ogrenci/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ogrenci/Create
        public ActionResult OgrenciEkle()
        {
            return View();
        }

        // POST: Ogrenci/Create
        [HttpPost]
        public ActionResult OgrenciEkle(Ogrenci yeniOgrenci)
        {
            try
            {
                Ogrenci eklenecekOgrenci = new Ogrenci()
                {
                    Adi = yeniOgrenci.Adi,
                    Soyadi = yeniOgrenci.Soyadi,
                    TcNo = yeniOgrenci.TcNo,
                    BolumAdi = yeniOgrenci.BolumAdi,
                    FakulteAdi = yeniOgrenci.FakulteAdi


                };
                OgrenciData.OgrenciList.Add(eklenecekOgrenci);


                return RedirectToAction("OgrenciListele");      

            }
            catch
            {
                return View();
            }
        }

        // GET: Ogrenci/Edit/5
        public ActionResult Edit(int id)
        {
            var ogr = OgranciVeri.OgrenciData.OgrenciList.Where(s => s.Id == id).FirstOrDefault();
            //var ogr = OgranciVeri.OgrenciData.OgrenciList.Where(s => s.Id == id).FirstOrDefault();
            return View(ogr);
        }

        // POST: Ogrenci/Edit/5
        [HttpPost]
        public ActionResult Edit(Ogrenci ogr)
        {
            var adi = ogr.Adi;
            var soyadi = ogr.Soyadi;
            var bolum = ogr.BolumAdi;
            var fakul = ogr.Fakultesi;

            var ogrenci = OgranciVeri.OgrenciData.OgrenciList.Where(s => s.Id == ogr.Id).FirstOrDefault();
            OgranciVeri.OgrenciData.OgrenciList.Remove(ogrenci);
            OgranciVeri.OgrenciData.OgrenciList.Add(ogr);

            return RedirectToAction("OgrenciListele");


        }

        // GET: Ogrenci/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ogrenci/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
