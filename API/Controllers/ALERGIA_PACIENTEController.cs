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
    public class ALERGIA_PACIENTEController : ApiController
    {
        private MODEL1 db = new MODEL1();

        [HttpGet]
        [ResponseType(typeof(ALERGIA_PACIENTE))]
        public IHttpActionResult Listar(string id)
        {
            var alergias = db.sp_listar_alergia_paciente_por_cedula(id);
            if (alergias == null)
            {
                return NotFound();
            }

            return Ok(alergias);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ALERGIA_PACIENTEExists(string id)
        {
            return db.ALERGIA_PACIENTE.Count(e => e.CEDULA_P == id) > 0;
        }
    }
}