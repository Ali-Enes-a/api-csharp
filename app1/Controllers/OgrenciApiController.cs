using app1.Models;
using app1.OgranciVeri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace app1.Controllers
{
    public class OgrenciApiController : ApiController
    {
        // GET: api/OgrenciApi
        public IEnumerable<Ogrenci> Get()
        {
            return OgrenciData.OgrenciList;
        }

        // GET: api/OgrenciApi/5
        public IHttpActionResult Get(int id)
        {
            var arananOgrenci = (OgrenciData.OgrenciList.Where(u => u.Id == id)).FirstOrDefault();
            if (arananOgrenci == null)
                return NotFound();
            else
                return Ok(arananOgrenci);
        }

        // POST: api/OgrenciApi
        [HttpPost]
        public IHttpActionResult Post([FromBody] Ogrenci yeniOgrenci)
        {
            var ogrenciAdi = yeniOgrenci != null ? yeniOgrenci.Adi : "";
            var ogrenciSoyadi = yeniOgrenci != null ? yeniOgrenci.Soyadi : "";
            var tcNo = yeniOgrenci?.TcNo ?? 0;
            var bolumAdi = yeniOgrenci != null ? yeniOgrenci.BolumAdi : "";
            var fakulteAdi = yeniOgrenci != null ? yeniOgrenci.FakulteAdi : "";
            OgrenciData.OgrenciList.Add(yeniOgrenci);
            return Ok(ogrenciAdi);

        }


        // PUT: api/OgrenciApi/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/OgrenciApi/5
        public void Delete(int id)
        {
        }
    }
}
