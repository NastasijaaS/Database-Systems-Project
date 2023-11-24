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
    public class PakovanjaController : ControllerBase
    {
        [Route("VratiSveLekoveUpakovaneU/{pak}")]
        [HttpGet]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult VratiSveLekoveUpakovaneU(string pak)
        {
            try
            {
                var res = DataProvider.VratiLekovePoPakovanju(pak);
                return Ok(new JsonResult(res));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("UpakujLek/{idLek}/{idPak}/{kol}/{sastav}")]
        [HttpPost]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult UpakujLek(int idLek, int idPak, int kol, string sastav)
        {
            try
            {
                DataProvider.UpakujLek(idLek, idPak, kol, sastav);
                return Ok("Lek je uspesno upakovan!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Route("IzmeniSastavPakovanja/{idPak}/{lekId}/{staraKol}/{novaKol}/{noviSastav}")]
        [HttpPut]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult IzmeniSastavPakovanja(int idPak, int lekId, int staraKol, int novaKol, string noviSastav)
        {
            try
            {
                DataProvider.IzmeniSastavPakovanja(idPak, lekId, staraKol, novaKol, noviSastav);
                return Ok("Sastav i kolicina za pakovanje su uspesno izmenjeni!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Nece iz nekog razloga...
        [Route("ObrisiVezu/{idLek}/{idPak}/{kol}")]
        [HttpDelete]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult ObrisiVezu(int idLek, int idPak, int kol)
        {
            try
            {
                DataProvider.ObrisiVezuLekPakovanje(idLek, idPak, kol);
                return Ok("Veza uspesno obrisana!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
