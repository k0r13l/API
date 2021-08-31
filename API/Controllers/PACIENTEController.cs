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
    public class PACIENTEController : ApiController
    {
        private MODEL1 db = new MODEL1();

        [HttpGet]
        public IHttpActionResult infoPaciente(string id)
        {
            var temp = db.sp_listar_info_paciente(id);
            return Ok(temp);
        }

        [HttpGet]
        public IHttpActionResult Login(string id, string id1)
        {
            var temp = db.sp_buscar_usuario_paciente(id, id1);
            return Ok(temp);
        }

        [HttpPost]
        [ResponseType(typeof(PACIENTE))]
        public IHttpActionResult Registrar([FromBody]PACIENTE paciente)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (PACIENTEExists(paciente.CEDULA))
            {
                return Ok("No se pudo insertar, la llave ya existe");
            }
            else
            {
                db.PACIENTE.Add(paciente);
                db.SaveChanges();
            }

            return Ok("Insertado correcto");
        }

        [HttpPut]
        [ResponseType(typeof(PACIENTE))]
        public IHttpActionResult Actualizar([FromBody] PACIENTE paciente)
        {
            var pacienteTemp = db.PACIENTE.FirstOrDefault(x => x.CEDULA == paciente.CEDULA);
            if (paciente.ESTADO_CIVIL != "")
            {
                pacienteTemp.ESTADO_CIVIL = paciente.ESTADO_CIVIL;
            }

            if (paciente.PROVINCIA != "")
            {
                pacienteTemp.PROVINCIA = paciente.PROVINCIA;
            }

            if (paciente.CANTON != "")
            {
                pacienteTemp.CANTON = paciente.CANTON;
            }

            if (paciente.DISTRITO != "")
            {
                pacienteTemp.DISTRITO = paciente.DISTRITO;
            }

            if (paciente.OTRAS_SEÑAS != "")
            {
                pacienteTemp.OTRAS_SEÑAS = paciente.OTRAS_SEÑAS;
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

        private bool PACIENTEExists(string id)
        {
            return db.PACIENTE.Count(e => e.CEDULA == id) > 0;
        }
    }
}