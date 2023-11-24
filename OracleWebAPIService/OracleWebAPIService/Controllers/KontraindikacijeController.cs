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
    public class KontraindikacijeController : ControllerBase
    {
        //Radi.
        [Route("VratiKontraindikacijeZaLek/{sbr}")]
        [HttpGet]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult VratiKontraindikacijeZaLek(int sbr)
        {
            try
            {
                var res = DataProvider.VratiSveKontraindikacijeLeka(sbr);
                return Ok(res);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Radi.
        [Route("DodajKontraindikacijuZaLek/{sbr}/{opis}")]
        [HttpPost]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult DodajKontraindikacijuZaLek(int sbr, string opis)
        {
            try
            {
                DataProvider.DodajKontraindikaciju(sbr, opis);
                return Ok("Uspesno dodata kontraindikacija!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Radi.
        [Route("IzmeniKontraindikaciju/{sbr}/{opis}")]
        [HttpPut]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult IzmeniKontraindikaciju(int sbr, string opis)
        {
            try
            {
                DataProvider.IzmeniKontraindikaciju(sbr, opis);
                return Ok("Indikacija uspesno izmenjena!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Radi.
        [Route("UkloniKontraindikaciju/{ind}")]
        [HttpDelete]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult UkloniKontraindikaciju(int ind)
        {
            try
            {
                DataProvider.UkloniKontraindikaciju(ind);
                return Ok("Kontraindikacija uspesno uklonjena!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
