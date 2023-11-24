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
    public class ZaposleniController : ControllerBase
    {

        //Iz nekog razloga serijalizacija za DateTime objekat ne radi, ali se podaci u 
        //bazi (preko oracle sqldeveloper) prikazuju validno.
        [Route("VratiSveZaposlene")]
        [HttpGet]
        [ProducesResponseType(400)]
        public IActionResult VratiSveZaposlene()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveZaposlene());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Vraca objekat tipa farmaceut i tip iz koga je farmaceut izveden (zaposleni)
        [Route("VratiFarmaceuta/{mbr}")]
        [HttpGet]
        [ProducesResponseType(400)]
        public IActionResult VratiFarmaceuta(string mbr)
        {
            try
            {
                return new JsonResult(DataProvider.VratiFarmaceuta(mbr));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Kroz body saljemo zaposlenog sa svim atributima, a kroz url saljemo ostale parametre:
        [Route("DodajZaposlenog/{dipl}/{obnovio}/{zaposli}/{idMesta}/{radiOd}")]
        [HttpPost]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult DodajZaposlenog([FromBody] Zaposleni z, DateTime dipl, DateTime obnovio, bool zaposli, int idMesta, DateTime radiOd)
        {
            try
            {
                DataProvider.DodajZaposlenog(z.MaticniBroj, z.Ime, z.Prezime, z.DatumRodjenja, z.Adresa, z.BrojTelefona, z.Farmaceut, dipl, obnovio, zaposli, idMesta, radiOd);
                return Ok("Novi zaposleni uspesno dodat!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Menja sve elemente koji pripadaju jednom zaposlenom, bilo da je obican zaposleni ili 
        //farmaceut:
        [Route("IzmeniZaposlenog")]
        [HttpPut]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult IzmeniZaposlenog([FromBody] Zaposleni z)
        {
            try
            {
                DataProvider.PromeniZaposlenog(z.MaticniBroj, z.Ime, z.Prezime, z.DatumRodjenja, z.Adresa, z.BrojTelefona.ToString());
                return Ok("Radnik sa maticnim brojem: " + z.MaticniBroj + " uspesno azuriran!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Evidencija obnavljanja licence zaposlenog:
        [Route("ObnoviLicencuFarmaceutu/{mbr}/{date}")]
        [HttpPut]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult ObnoviLicencuFarmaceutu(string mbr, DateTime date)
        {
            try
            {
                DataProvider.ObnoviLicencuFarmaceutu(mbr, date);
                return Ok("Uspesno obnovljena licenca farmaceutu: " + mbr + " za datum: " + date.ToShortDateString());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        //Brisemo radnika iz baze podataka, takodje radi isto i za zaposlenog!
        [Route("ObrisiRadnika/{mbr}")]
        [HttpDelete]
        [ProducesResponseType(400)]
        [ProducesResponseType(200)]
        public IActionResult ObrisiRadnika(string mbr)
        {
            try
            {
                DataProvider.ObrisiZaposlenog(mbr);
                return Ok("Zaposleni sa Maticnim brojem: " + mbr + " je uspesno obrisan iz baze podataka!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

    }
}
