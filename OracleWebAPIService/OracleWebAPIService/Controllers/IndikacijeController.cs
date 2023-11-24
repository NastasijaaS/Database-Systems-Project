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
    public class IndikacijeController : ControllerBase
    {
        //Radi.
        [Route("VratiIndikacijeZaLek/{sbr}")]
        [HttpGet]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult VratiIndikacijeZaLek(int sbr)
        {
            try
            {
                var res = DataProvider.VratiSveIndikacijeLeka(sbr);
                return Ok(res);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("DodajIndikacijuZaLek/{sbr}/{opis}")]
        [HttpPost]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult DodajIndikacijuZaLek(int sbr, string opis)
        {
            try
            {
                DataProvider.DodajIndikaciju(sbr, opis);
                return Ok("Uspesno dodata indikacija!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("IzmeniIndikaciju/{sbr}/{opis}")]
        [HttpPut]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult IzmeniIndikaciju(int sbr, string opis)
        {
            try
            {
                DataProvider.IzmeniIndikaciju(sbr, opis);
                return Ok("Kontraindikacija uspesno izmenjena!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("UkloniIndikaciju/{ind}")]
        [HttpDelete]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult UkloniIndikaciju(int ind)
        {
            try
            {
                DataProvider.UkloniIndikaciju(ind);
                return Ok("Indikacija uspesno uklonjena!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
