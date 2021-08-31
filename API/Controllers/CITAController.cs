using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using API.Models;

namespace API.Controllers
{
    public class CITAController : ApiController
    {
        private MODEL1 db = new MODEL1();

        [HttpGet]
        [ResponseType(typeof(CITA))]
        public IHttpActionResult Listar(string id)
        {
            var citas = db.sp_listar_citas_por_cedula(id);
            if (citas == null)
            {
                return NotFound();
            }

            return Ok(citas);
        }

        [HttpPost]
        [ResponseType(typeof(void))]
        public IHttpActionResult Registrar([FromBody] CITA cita)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (CITAExists(cita.CEDULA_P))
            {
                return Ok("No se pudo insertar, la llave ya existe");
            }
            else
            {
                db.CITA.Add(cita);
                db.SaveChanges();
            }

            return Ok("Insertado correcto");
        }

        [HttpPut]
        [ResponseType(typeof(CITA))]
        public IHttpActionResult Actualizar(CITA cita)
        {
            var citaTemp = db.CITA.FirstOrDefault(x => x.ID == cita.ID);

            if (cita.DESCRIPCION != "")
            {
                citaTemp.DESCRIPCION = cita.DESCRIPCION;
            }
            db.SaveChanges();
            return Ok("Actualización correcta");
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CITAExists(string id)
        {
            return db.CITA.Count(e => e.CEDULA_P == id) > 0;
        }
    }
}