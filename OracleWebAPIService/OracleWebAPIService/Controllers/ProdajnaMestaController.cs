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
    public class ProdajnaMestaController : ControllerBase
    {

        [Route("PreuzmiProdajnaMesta")]
        [HttpGet]
        [ProducesResponseType(400)]
        public IActionResult PreuzmiProdajnaMesta()
        {
            try
            {
                return new JsonResult(DatabaseAccess.DataProvider.VratiSveProdavnice());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Route("DodajProdajnoMesto")]
        [HttpPost]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult DodajProdajnoMesto([FromBody] ProdajnoMesto p)
        {
            try
            {
                DataProvider.DodajProdajnoMesto(p);
                return Ok("Prodajno mesto je dodato!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        
        [Route("IzmeniProdajnoMesto")]
        [HttpPut]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult IzmeniProdajnoMesto([FromBody] ProdajnoMesto p)
        {
            try
            {
                var res = DataProvider.AzurirajProdajnoMesto(p);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [Route("ObrisiProdajnoMesto/{idMesta}")]
        [HttpDelete]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult ObrisiProdajnoMesto(int idMesta)
        {
            try
            {
                DataProvider.ObrisiProdajnoMesto(idMesta);
                return Ok("Prodajno mesto sa id-jem: " + idMesta.ToString() + " je uspesno obrisano!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
