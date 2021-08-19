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


                return View();

            }
            catch
            {
                return View();
            }
        }

        // GET: Ogrenci/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Ogrenci/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
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
