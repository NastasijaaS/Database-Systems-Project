using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatabaseAccess;
using DatabaseAccess.Entiteti;
using DatabaseAccess.DTOs;

namespace OracleWebAPIService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ReceptiController : ControllerBase
    {
        [Route("VratiSveRecepte")]
        [HttpGet]
        [ProducesResponseType(400)]
        public IActionResult VratiSveRecepte()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveRecepte());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Radi.
        [Route("DodajRecept/{sbr}/{lekar}/{izdat}/{realizovan}/{zaposleni}/{mesto}")]
        [HttpPost]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult DodajRecept(int sbr, string lekar, DateTime izdat, DateTime realizovan, string zaposleni, int mesto)
        {
            try
            {
                DataProvider.DodajRecept(sbr, lekar, izdat, realizovan, zaposleni, mesto);
                return Ok("Recept je uspesno kreiran!");
            }
            catch(Exception ex)
            {
                return BadRequest(ex);
            }
        }


        [Route("DodajLekNaRecept/{rec}/{lek}")]
        [HttpPut]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult DodajLekNaRecept(int rec, int lek)
        {
            try
            {
                var res = DataProvider.DodajLekNaRecept(rec, lek);
                return Ok(new JsonResult(res));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Radi.
        [Route("ObrisiRecept/{id}")]
        [HttpDelete]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult ObrisiRecept(int id)
        {
            try
            {
                DataProvider.ObrisiRecept(id);
                return Ok("Recept uspesno obrisan iz baze podataka!");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
