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
    public class VACUNA_PACIENTEController : ApiController
    {
        private MODEL1 db = new MODEL1();

        [HttpGet]
        [ResponseType(typeof(VACUNA_PACIENTE))]
        public IHttpActionResult Listar(string id)
        {
            var vacunas = db.sp_listar_vacuna_paciente_por_cedula(id);
            if (vacunas == null)
            {
                return NotFound();
            }

            return Ok(vacunas);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool VACUNA_PACIENTEExists(string id)
        {
            return db.VACUNA_PACIENTE.Count(e => e.NOMBRE_VACUNA == id) > 0;
        }
    }
}