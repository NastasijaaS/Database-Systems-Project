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
    public class LekoviController : ControllerBase
    {
        //Vraca sve iz baze podataka lekove:
        [Route("VratiSveLekove")]
        [HttpGet]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult VratiSveLekove()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveLekovePregled());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Vraca sve lekove odgovarajuceg tipa:
        [Route("VratiSveLekoveTipa/{tip}")]
        [HttpGet]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult VratiSveLekoveTipa(string tip)
        {
            try
            {
                var res = DataProvider.VratiLekovePoTipu(tip);
                return Ok(new JsonResult(res));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Vraca sve lekove proizvodjaca:
        [Route("VratiSveLekoveProizvodjaca/{pro}")]
        [HttpGet]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult VratiSveLekoveProizvodjaca(string pro)
        {
            try
            {
                var res = DataProvider.VratiLekovePoProizvodjacu(pro);
                return Ok(new JsonResult(res));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Dodajemo novi lek u bazi podataka:
        [Route("DodajLek")]
        [HttpPost]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult DodajLek([FromBody] Lek l)
        {
            try
            {
                DataProvider.DodajLek(l);
                return Ok("Lek je uspesno dodat!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Dodajemo lek u novo prodajno mesto:
        [Route("DodajLekUProdajnoMesto/{idLeka}/{idMesta}/{kol}")]
        [HttpPost]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult DodajLekUProdajnoMesto(int idLeka, int idMesta, int kol)
        {
            try
            {
                DataProvider.DodajLekUProdajnoMesto(idLeka, idMesta, kol);
                return Ok("Lek je uspesno dodat u prodajno mesto!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [Route("DodajProizvodjaca")]
        [HttpPost]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult DodajProizvodjaca([FromBody] Proizvodjac p)
        {
            try
            {
                DataProvider.DodajProizvodjaca(p);
                return Ok("Novi proizvodjac sa nazivom: " + p.Naziv + " je uspesno dodat u bazu podataka!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Menjamo atribute leka:
        [Route("IzmeniLek/{id}/{cena}/{procenat}/{naRecept}")]
        [HttpPut]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult IzmeniLek(int id, int cena, int procenat, int naRecept) 
        {
            try
            {
                DataProvider.IzmeniLek(id, cena.ToString(), procenat.ToString(), naRecept);
                return Ok("Lek sa serijskim brojem: " + id.ToString() + " je uspesno izmenjen!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Menjamo tip vec postojeceg leka:
        //Takodje, radi se update za odgovarajuce liste:
        [Route("IzmeniTipLeka/{lekId}/{novi}")]
        [HttpPut]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult IzmeniTipLeka(int lekId, string novi)
        {
            try
            {
                DataProvider.IzmeniTipLeka(lekId, novi);
                return Ok("Uspesno ste izmenili tip leka!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Izmeni proizvodjaca leka:
        [Route("IzmeniProizvodjacaLeku/{sbr}/{novi}")]
        [HttpPut]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult IzmeniProizvodjacaLeku(int sbr, string novi)
        {
            try
            {
                DataProvider.IzmeniProizvodjaca(sbr, novi);
                return Ok("Uspesno ste promenili proizvodjaca za lek sa serijskim brojem: " + sbr + " na: " + novi);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Brisemo lek iz baze podataka:
        [Route("ObrisiLek/{id}")]
        [HttpDelete]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult ObrisiLek(int id)
        {
            try
            {
                DataProvider.ObrisiLekIzSistema(id);
                return Ok("Lek sa id-jem: " + id.ToString() + " je uspesno obrisan iz baze podataka!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
